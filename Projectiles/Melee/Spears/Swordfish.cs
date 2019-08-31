using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Melee.Spears {
	public class Swordfish : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.Swordfish) target.AddBuff(mod.BuffType("Bleed"), 180); // 60 frames = 1 second.
			if (projectile.type == ProjectileID.Swordfish) {
				if (Main.rand.NextFloat() < .2500f) target.AddBuff(mod.BuffType("Suffocate"), 90);
			}
		}
	}
}