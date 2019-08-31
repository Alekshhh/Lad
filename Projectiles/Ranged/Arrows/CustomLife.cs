using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Projectiles.Ranged.Arrows {
	public class CustomLife : ModProjectile {
		public override void SetDefaults() {
			projectile.width = 12;
			projectile.height = 12;
			drawOffsetX = -3;
			projectile.ranged = true;
			aiType = ProjectileID.WoodenArrowFriendly;
			projectile.aiStyle = 1;
			projectile.hostile = false;
            projectile.friendly = true;
			projectile.tileCollide = true;
		}
		
		public override void AI() {
			if (Main.rand.NextBool(2)) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 5, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].noGravity = true;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			if (target.type != NPCID.TargetDummy && target.CanBeChasedBy(projectile, false)) {
				Player player = Main.player[projectile.owner]; // Projectile lifesteal.
				player.statLife += damage / 8;
				player.HealEffect(damage / 8);
			}
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 5, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 1f;
			}
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity) {
			Main.PlaySound(SoundID.Dig, projectile.position);
			for (int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 5, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].velocity *= 1f;
			}
            return true;
		}
	}
}