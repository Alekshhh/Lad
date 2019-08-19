using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class IceBolt : GlobalProjectile { // Specific to projectiles.
		public override void SetDefaults(Projectile projectile) {
			if (projectile.type == ProjectileID.IceBolt) {
				projectile.damage = 6;
			}
		}
		 
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.IceBolt) target.AddBuff(BuffID.Frostburn, 45); // 60 frames = 1 second.
        }
	}
}
 