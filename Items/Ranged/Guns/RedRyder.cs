using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Guns {
	public class RedRyder : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.RedRyder) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.crit = 6;
			}
		}
	}
}