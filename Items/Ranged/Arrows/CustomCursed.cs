using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Arrows {
	public class CustomCursed : ModProjectile {
		public override void SetDefaults() { // Specific to items.
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
		}
		
		public override void AI(Projectile projectile) {
			if (Main.rand.NextBool(2)) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 75, 0, 0, 0, default(Color), 3f);
				Main.dust[dustIndex].noGravity = true;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.CursedInferno, 60);
		}
	}
}