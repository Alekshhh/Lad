using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Melee.Flails {
	public class BallOHurt : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.BallOHurt) target.AddBuff(BuffID.CursedInferno, 60); // 60 frames = 1 second.
		}
		
		public override void AI(Projectile projectile) {
			if (projectile.type == ProjectileID.BallOHurt) {
				if (Main.rand.NextBool(2)) {
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 3f);
					Main.dust[dustIndex].noGravity = true;
				}
			}
		}
	}
}