using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Spears {
	public class Spear : GlobalItem {
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Spear) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
			}
		}
	}
}