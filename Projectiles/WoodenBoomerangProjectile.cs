using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class WoodenBoomerangProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.WoodenBoomerang) {
				if (Main.rand.NextFloat() < .2500f) target.AddBuff(BuffID.Confused, 300); // 60 frames = 1 second.
			}
        }
	}
}