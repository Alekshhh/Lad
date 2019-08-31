using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Melee.Spears {
	public class Spear : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Spear) target.AddBuff(mod.BuffType("Bleed"), 180); // 60 frames = 1 second.
		}
	}
}