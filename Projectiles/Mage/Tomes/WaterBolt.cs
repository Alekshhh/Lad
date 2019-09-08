using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Tomes {
	public class WaterBolt : GlobalProjectile {
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.WaterBolt) {
				projectile.timeLeft = 600;
			}
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.WaterBolt) target.AddBuff(mod.BuffType("Suffocate"), 60);
		}
	}
}