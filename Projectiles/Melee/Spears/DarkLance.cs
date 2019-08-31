using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Melee.Spears {
	public class DarkLance : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.DarkLance) target.AddBuff(BuffID.ShadowFlame, 90); // 60 frames = 1 second.
		}
	}
}