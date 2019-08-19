using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class TridentProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Trident) target.AddBuff(mod.BuffType("Bleed"), 180); // 60 frames = 1 second.
			if (projectile.type == ProjectileID.Trident) {
				if (Main.rand.NextFloat() < .2500f) target.AddBuff(mod.BuffType("Suffocate"), 90);
			}
		}
	}
}