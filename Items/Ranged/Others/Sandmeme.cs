using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Others {
	public class Sandmeme : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Sandgun) { // Need the if statement for specified weapon!
				item.damage = 4;
				item.useTime = 1;
				item.useAnimation = 1;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
			if (item.type == ItemID.Sandgun) {
				foreach (TooltipLine line2 in tooltips) { // This code changes existing tooltips.
					if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "'Memes, Jack!'";
				}
			}
		}
	}
}