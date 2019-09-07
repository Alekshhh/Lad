using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Wands {
	public class AquaScepter : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.WaterStream) target.AddBuff(mod.BuffType("Suffocate"), 60);
		}
	}
}