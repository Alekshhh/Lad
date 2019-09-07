using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Mage.Wands {
	public class OreStaff : GlobalProjectile {
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.EmeraldBolt || projectile.type == ProjectileID.EmeraldBolt) {
				projectile.penetrate = 1;
			}
			
			if (projectile.type == ProjectileID.RubyBolt || projectile.type == ProjectileID.DiamondBolt) {
				projectile.penetrate = 2;
			}
			
			if (projectile.type == ProjectileID.AmberBolt) {
				projectile.penetrate = 3;
				projectile.usesLocalNPCImmunity = true;
				projectile.localNPCHitCooldown = 10;
			}
		}
	}
}