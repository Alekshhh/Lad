using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class Flamarang : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Flamarang) { // Need the if statement for specified weapon!
				item.autoReuse = true;
				item.useTime = 26;
				item.useAnimation = 26;
				item.damage = 34;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Flamarang) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to melt on hit");
                tooltips.Add(line1);
			}
		}
	}
}