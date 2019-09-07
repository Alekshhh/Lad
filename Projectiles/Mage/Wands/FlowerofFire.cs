using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Wands {
	public class FlowerofFire : GlobalProjectile { // Specific to projectiles.
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.BallofFire) {
				projectile.penetrate = 5;
			}
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.BallofFire && Main.rand.NextFloat() < .3333f) target.AddBuff(mod.BuffType("Melt"), 90);
		}
	}
}