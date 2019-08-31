using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Others {
	public class Harpoon : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Harpoon) { // Need the if statement for specified weapon!
				item.damage = 16;
			}
		}
	}
}