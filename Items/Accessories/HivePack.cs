using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class HiveBackpack : GlobalItem {
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.HiveBackpack) {
                foreach (TooltipLine line2 in tooltips) {
					if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "Has a chance to replace friendly bees with bigger, stronger bees";
				}
			}
		}
	}
}