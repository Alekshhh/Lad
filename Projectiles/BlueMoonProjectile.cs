using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles {
	public class BlueMoonProjectile : GlobalProjectile { // Specific to projectiles.
	
		public int timer; // This will act as our projectile.ai[1]
		
		public override bool InstancePerEntity => true; // Makes the code work
		
		public override void AI(Projectile projectile) {
			if (projectile.type == ProjectileID.BlueMoon) {
				timer++;
                if (timer >= 15) { // This creates projectiles every half second.
                    Main.PlaySound(SoundID.Item21, projectile.position);
                    for (int i =0; i< Main.rand.Next(3,5); i++) { // Randomizes amount of projectiles.
                        Projectile.NewProjectile(projectile.Center, new Vector2((int)(projectile.velocity.X + Main.rand.Next(-5, 5))* .2f, -3f), mod.ProjectileType("Water"), projectile.damage/4, 0, projectile.owner);
                    }
                    timer = 0;
				}
			}
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.BlueMoon) target.AddBuff(mod.BuffType("Suffocate"), 300); // 60 frames = 1 second.
		}
	}
}