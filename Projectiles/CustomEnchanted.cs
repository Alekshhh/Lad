using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles {
	public class CustomEnchanted : ModProjectile { // Specific to projectiles.
		public override void SetDefaults() {
			projectile.width = 18;
			projectile.height = 18;
			projectile.aiStyle = 3;
			projectile.hostile = false;
            projectile.friendly = true;
			projectile.penetrate = -1;
		}
	
		public override void AI() { // Thanks pixlgray!
			            // Boomerang rotation
            projectile.rotation += 0.02f * (float)projectile.direction;

            // Boomerang sound
            if (projectile.soundDelay == 0) {
                projectile.soundDelay = 8;
                Main.PlaySound(SoundID.Item7, projectile.position);
            }

            Player target = Main.player[projectile.owner];

            // This could probably be shortened to a Vector2 variable.
            Vector2 shootTo = Vector2.Normalize(target.Center - projectile.Center);

            // After 3/4 second, home onto player
            if (projectile.ai[0] >= 45f) {
                float veloMultiplier = 8f;
                // Let it pass through blocks
                projectile.tileCollide = false;
                
                // Get a desired velocity number
                shootTo.X *= veloMultiplier;
                shootTo.Y *= veloMultiplier;
                
                //Set the velocities to the shoot values
                projectile.velocity.X = shootTo.X;
                projectile.velocity.Y = shootTo.Y;
			
                // Kill it on player collision
                Rectangle rectangle = new Rectangle((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height);
                Rectangle value2 = new Rectangle((int)Main.player[projectile.owner].position.X, (int)Main.player[projectile.owner].position.Y, Main.player[projectile.owner].width, Main.player[projectile.owner].height);
                if (rectangle.Intersects(value2)) {
                    projectile.Kill();
                }
            }
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(mod.BuffType("Dazzle"), 180);
			if (Main.rand.NextFloat() < .2000f) target.AddBuff(BuffID.Confused, 300); // 60 frames = 1 second.
		}
	}
}