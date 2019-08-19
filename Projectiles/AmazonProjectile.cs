using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class AmazonProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.JungleYoyo) target.AddBuff(BuffID.Poisoned, 300); // 60 frames = 1 second.
		}
	}
}