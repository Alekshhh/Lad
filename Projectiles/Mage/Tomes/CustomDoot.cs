using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Mage.Tomes {
	public class CustomDoot : ModProjectile {
		public override void SetDefaults() {
			projectile.width = 22;
			projectile.height = 26;
			projectile.aiStyle = 0;
			projectile.hostile = false;
            projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.ignoreWater = true;
			projectile.usesLocalNPCImmunity = true;
			projectile.localNPCHitCooldown = 20;
			projectile.timeLeft = 300;
			}
		
		public override void AI() {
			projectile.rotation = projectile.velocity.ToRotation() + (projectile.spriteDirection == 1 ? 0f : MathHelper.Pi);
			projectile.spriteDirection = projectile.direction = (projectile.velocity.X > 0).ToDirectionInt();
			if (projectile.spriteDirection == -1) {
				drawOffsetX = 0;
				drawOriginOffsetY = 0;
				drawOriginOffsetX = 0;
			}
			for(int i = 0; i < 200; i++) {
				NPC target = Main.npc[i];
				NPC npc = Main.npc[i];
				if (target.CanBeChasedBy(projectile, false) && target.type != NPCID.TargetDummy) {
					float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
					float shootToY = target.position.Y - projectile.Center.Y;
					float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));
					if(distance < 240f && !target.friendly && target.active) {
						distance = 3f / distance;
						//This code causes the projectile to curve towards the target.
						//Thanks Dominic K for the base!
						Vector2 currentPosition = projectile.Center;
						Vector2 desiredPosition = target.Center;
						float inverseSharpness = 20f; //the lower this is, the sharper the curve
						Vector2 distNorm = Vector2.Normalize(desiredPosition - currentPosition)*5;
						projectile.velocity = (projectile.velocity * (inverseSharpness - 1f) + distNorm) / inverseSharpness;
					}
				}
			}
			for (int i = 0; i < 1; i++) { // i < number of particles.
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 27, 0f, 0f, 0, default(Color), 2f);
				Main.dust[dustIndex].noGravity = true;
			}
		}
		
		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Item10, projectile.position);
			for (int i = 0; i < 4; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 27, 0f, 0f, 0, default(Color), 2f);
				Main.dust[dustIndex].noGravity = true;
				Main.dust[dustIndex].velocity *= 3f;
			}
		}
    }
}