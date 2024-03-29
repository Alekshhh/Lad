using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Lad.Projectiles.Melee.Yoyos {
	public class Artery : GlobalProjectile { // Specific to projectiles.
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) {
			if (projectile.type == ProjectileID.CrimsonYoyo) {
// This line checks targets that aren't Target Dummies AND critters. Very useful! Thank you Uncle Danny!
// Note to self: || = OR, && = AND.
				if (target.type != NPCID.TargetDummy && target.CanBeChasedBy(projectile, false)) {
					Player player = Main.player[projectile.owner]; // Projectile lifesteal.
					player.statLife += damage / 8;
					player.HealEffect(damage / 8);
				}
			}
		}
	}
}