using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Tomes {
	public class WaterBolt : GlobalProjectile {
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.WaterBolt) target.AddBuff(mod.BuffType("Suffocate"), 60);
		}
	}
}