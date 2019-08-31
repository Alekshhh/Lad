using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Melee.Yoyos {
	public class Rally : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Rally) target.AddBuff(mod.BuffType("Dazzle"), 180);
		}
	}
}