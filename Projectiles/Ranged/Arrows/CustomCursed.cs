using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Projectiles.Ranged.Arrows {
	public class CustomCursed : ModProjectile {
		public override void SetDefaults() {
			projectile.width = 12;
			projectile.height = 12;
			drawOffsetX = -3;
			projectile.ranged = true;
			aiType = ProjectileID.WoodenArrowFriendly;
			projectile.aiStyle = 1;
			projectile.hostile = false;
            projectile.friendly = true;
			projectile.tileCollide = true;
		}
		
		public override void AI() {
			if (Main.rand.NextBool(2)) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 3f);
				Main.dust[dustIndex].noGravity = true;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.CursedInferno, 60);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 2f;
			}
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 2f;
			}
            return true;
		}
	}
}