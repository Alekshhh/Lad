using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Guns {
	public class Musket : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Musket) { // Need the if statement for specified weapon!
				item.damage = 45;
				item.useTime = 80;
				item.useAnimation = 80;
				item.crit = 16;
				item.autoReuse = false;
			}
		}
	}
}