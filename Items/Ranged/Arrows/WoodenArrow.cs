using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Bows {
	public class WoodBows : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.WoodenArrow) { // Need the if statement for specified weapon!
				item.damage = 4;
			}
		}
	}
}
