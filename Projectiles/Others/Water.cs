using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Others {
	public class Water : ModProjectile { // Specific to projectiles.
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Water");
		}
		
		public override void SetDefaults() {
			projectile.width = 16;
			projectile.height = 16;
            projectile.penetrate = 1;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.hostile = false;
            projectile.friendly = true;
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
		}
		
// This is JUST for dust, does not effect anything else.
		public override void AI() {
			for (int i = 0; i < 10; i++) {
				projectile.alpha = 255; // Makes the projectile invisible.
				float x = projectile.Center.X - projectile.velocity.X / 10f * (float)i;
				float y = projectile.Center.Y - projectile.velocity.Y / 10f * (float)i;
				int num = Dust.NewDust(new Vector2(x, y), 0, 0, 29);
				Main.dust[num].alpha = projectile.alpha;
				Main.dust[num].velocity = Vector2.Zero;
				Main.dust[num].noGravity = true;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(mod.BuffType("Suffocate"), 60);
		}
	}
}