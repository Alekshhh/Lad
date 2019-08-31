using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Guns {
	public class Boomstick : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Boomstick) { // Need the if statement for specified weapon!
				item.damage = 8;
				item.useTime = 48;
				item.useAnimation = 48;
			}
		}
	}
}