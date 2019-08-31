using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Projectiles.Ranged.Arrows {
	public class HellwingBat : GlobalProjectile {
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Hellwing) target.AddBuff(BuffID.OnFire, 180); // 60 frames = 1 second.
		}
	}
}