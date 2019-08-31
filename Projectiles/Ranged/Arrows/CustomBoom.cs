using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Projectiles.Ranged.Arrows {
	public class CustomBoom : ModProjectile {
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
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0, 0, 0, default(Color), 1f);
				Main.dust[dustIndex].noGravity = true;
			}
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("Boom2"), 12, 2, projectile.owner, 0f, 0f); // Uses said projectile for attack.
			Main.PlaySound(SoundID.Item14, projectile.position); // Sound it plays when it hits.
			// Fire dust.
			for (int i = 0; i < 80; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0f, 0f, 100, default(Color), 3f); // Either increases dust amount or makes dust bigger.
				Main.dust[dustIndex].noGravity = true; // Stays in the air and disappears faster.
				Main.dust[dustIndex].velocity *= 8f; // Increases radius particles reach.
			target.AddBuff(mod.BuffType("Melting"), 60);
			}
		}
		
		public override bool OnTileCollide(Vector2 oldVelocity) {
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("Boom2"), 12, 2, projectile.owner, 0f, 0f); // Uses said projectile for attack.
			Main.PlaySound(SoundID.Item14, projectile.position); // Sound it plays when it hits.
			// Fire dust.
			for (int i = 0; i < 80; i++) { // i < number of particles.
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 127, 0f, 0f, 100, default(Color), 3f);
				Main.dust[dustIndex].noGravity = true; // Stays in the air and disappears faster.
				Main.dust[dustIndex].velocity *= 8f; // Increases radius particles reach.
			}
			return true;
		}
	}
}