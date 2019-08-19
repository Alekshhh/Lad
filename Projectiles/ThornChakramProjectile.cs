using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles {
	public class ThornChakramProjectile : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.ThornChakram) target.AddBuff(BuffID.Poisoned, 300);
			if (projectile.type == ProjectileID.ThornChakram) {
				if (Main.rand.NextFloat() < .2500f) target.AddBuff(BuffID.Venom, 150); // 60 frames = 1 second.
			}
        }
	}
}