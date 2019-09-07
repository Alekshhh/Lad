using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Wands {
	public class Vilethorn : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.VilethornBase) target.AddBuff(BuffID.Poisoned, 180);
			if (projectile.type == ProjectileID.VilethornTip) target.AddBuff(BuffID.Venom, 90);
		}
	}
}