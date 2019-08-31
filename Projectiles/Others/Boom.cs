using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Others {
	public class Boom : ModProjectile { // Specific to projectiles.
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Boom");
		}
		
		public override void SetDefaults() {
            projectile.width = 120; // The hitbox in pixels. Each block is 16x16.
            projectile.height = 120;
            projectile.penetrate = -1; // Infinite penetration.
            projectile.ignoreWater = true;
            projectile.alpha = 255; // Makes the projectile invisible.
            projectile.tileCollide = false;
            projectile.hostile = false;
            projectile.friendly = true;
			projectile.timeLeft = 7; // 60 = 1 second.
		}
		
		public override void AI() { // Damages enemies during explosion, centered at original projectile size.
			if (projectile.owner == Main.myPlayer && projectile.timeLeft <= 7) {
				projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
				projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
				projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
				projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
				projectile.knockBack = 1;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 300);
		}
	}
}