using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Melee.Boomers {
	public class Flamarang : GlobalProjectile { // Specific to projectiles.
		 public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Flamarang) {
				Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("Boom"), 24, 2, projectile.owner, 0f, 0f); // Uses said projectile for attack.
				Main.PlaySound(SoundID.Item14, projectile.position); // Sound it plays when it hits.
				// Fire dust.
				for (int i = 0; i < 80; i++) {
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0f, 0f, 100, default(Color), 3f); // Either increases dust amount or makes dust bigger.
					Main.dust[dustIndex].noGravity = true; // Stays in the air and disappears faster.
					Main.dust[dustIndex].velocity *= 8f; // Increases radius particles reach.
				target.AddBuff(mod.BuffType("Melting"), 60);
				}
			}
		}
		
		public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity) { // When it hits a block.
			if (projectile.type == ProjectileID.Flamarang) {
				Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("Boom"), 24, 2, projectile.owner, 0f, 0f); // Uses said projectile for attack.
				Main.PlaySound(SoundID.Item14, projectile.position); // Sound it plays when it hits.
				// Fire dust.
				for (int i = 0; i < 80; i++) { // i < number of particles.
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0f, 0f, 100, default(Color), 3f); // Either increases dust amount or makes dust bigger.
					Main.dust[dustIndex].noGravity = true; // Stays in the air and disappears faster.
					Main.dust[dustIndex].velocity *= 8f; // Increases radius particles reach.
				}
			}
			return true;
		}
	}
}