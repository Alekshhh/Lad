using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
 
namespace Lad.Projectiles.Melee.Swords {
	public class EnchantedBeam : GlobalProjectile { // Specific to projectiles.
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.EnchantedBeam) {
				projectile.damage = 14;
			}
		}
	}
}