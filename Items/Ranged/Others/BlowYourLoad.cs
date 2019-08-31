using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Others {
	public class BlowYourLoad : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Blowpipe) {
				item.damage = 8;
				item.useTime = 42;
				item.useAnimation = 42;
			}
			
			if (item.type == ItemID.Blowgun) {
				item.damage = 24;
				item.useTime = 32;
				item.useAnimation = 32;
			}
			
			if (item.type == ItemID.Seed) {
				item.damage = 4;
			}
		}
	}
}