using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles {
	public class CascadeProjectile : GlobalProjectile { // Specific to projectiles.
		public override void AI(Projectile projectile) {
			if (projectile.type == ProjectileID.Cascade) {
// Randomly spews out projectiles. Note to self: Never. Do. This. Again.
// Thanks Yuyutsu!
				if (Main.rand.Next(30) == 0) {
					Main.PlaySound(SoundID.Item20, projectile.position);
					Projectile.NewProjectile(projectile.Center, new Vector2((int)(projectile.velocity.X + Main.rand.Next(-5, 5))* .3f, -3), mod.ProjectileType("Fire"), projectile.damage/2, projectile.knockBack, projectile.owner);
				}
			}
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Cascade) target.AddBuff(BuffID.OnFire, 300); // 60 frames = 1 second.
		}
	}
}