using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Projectiles.Ranged.Bullets {
	public class MeltBullet : ModProjectile {
		public override void SetDefaults() {
			projectile.width = 4;
			projectile.height = 4;
			projectile.ranged = true;
			aiType = ProjectileID.Bullet;
			projectile.aiStyle = 0;
			projectile.hostile = false;
            projectile.friendly = true;
			projectile.ignoreWater = true; 
			projectile.tileCollide = true;
			projectile.timeLeft = 80;
		}
		
		public override void AI() {
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(mod.BuffType("Melting"), 60);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 2f;
			}
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 2f;
			}
            return true;
		}
		
		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Item89, projectile.position);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 2f;
			}
		}
	}
}