using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles {
	public class EnchantedSwordProjectile : GlobalProjectile { // Specific to projectiles.
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.EnchantedBeam) {
				projectile.damage = 14;
			}
		}
	}
}