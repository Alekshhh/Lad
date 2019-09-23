using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

// Thanks to Dominic K for allowing me to use his antlion code!

namespace Lad.Projectiles.Others.NPCs {
    public class FallingSand : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sand");
        }

        public override void SetDefaults() {
            projectile.width = 14;
            projectile.height = 14;
            projectile.hostile = true;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
        }

        public override void AI() {
            projectile.velocity.Y += 0.1f;
            projectile.rotation += projectile.velocity.Length() / 24f;
			for (int index = 0; index <= 0.5f; index++) {
                int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 32, 0f, 0f, 100, default(Color), 1.2f);
			}
		}
		
        public override void Kill(int timeLeft) {
            for (int index = 0; index <= 10; index++) {
                Vector2 dustVelocity = Vector2.Normalize(Utils.RandomVector2(Main.rand, 3f, 10f));
                int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 85, 0f, 0f, 100, default(Color), 1.2f);
                Main.dust[dustIndex].noGravity = true;
                Main.dust[dustIndex].position = projectile.Center;
                Dust dustFromIndex = Main.dust[dustIndex];
                dustFromIndex.position.Y = dustFromIndex.position.Y + (float)Main.rand.Next(-10, 11);
                Main.dust[dustIndex].velocity = dustVelocity;
            }
        }
    }
}