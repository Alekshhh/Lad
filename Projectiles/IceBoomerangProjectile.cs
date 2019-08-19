using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class IceBoomerangProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.IceBoomerang) target.AddBuff(BuffID.Frostburn, 60); // 60 frames = 1 second.
        }
	}
}
 