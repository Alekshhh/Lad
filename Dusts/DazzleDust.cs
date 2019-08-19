using Terraria;
using Terraria.ModLoader;

namespace Lad.Dusts {
	public class DazzleDust : ModDust {
		public override void OnSpawn(Dust dust) {
			dust.velocity *= 0.2f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 1;
		}

		public override bool Update(Dust dust) {
			dust.position += dust.velocity * 1.2f;
			
			float light = 0.4f * dust.scale;
			Lighting.AddLight(dust.position, light, light, light); // Adds lighting.
			
			dust.scale *= 0.8f; // Note to self: do NOT go over 1.
			if (dust.scale < 0.2f) { // When the dust reaches a certain size, destroy it.
				dust.active = false;
			}
			return false;
		}
	}
}