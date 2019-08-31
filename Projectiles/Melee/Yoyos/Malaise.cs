using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Melee.Yoyos {
	public class Malaise : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.CorruptYoyo) target.AddBuff(BuffID.CursedInferno, 30); // 60 frames = 1 second.
		}
		
		public override void AI(Projectile projectile) {
			if (projectile.type == ProjectileID.CorruptYoyo) {
				if (Main.rand.NextBool(2)) {
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 1.5f);
					Main.dust[dustIndex].noGravity = true;
				}
			}
		}
	}
}