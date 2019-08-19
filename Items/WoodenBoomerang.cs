using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class WoodenBoomerang : GlobalItem {
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.WoodenBoomerang) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to confuse enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}