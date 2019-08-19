using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class SunfuryProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Sunfury) target.AddBuff(BuffID.OnFire, 300); // 60 frames = 1 second.
			if (projectile.type == ProjectileID.Sunfury) {
				if (Main.rand.NextFloat() < .2500f) target.AddBuff(mod.BuffType("Melt"), 90);
			}
		}
	}
}