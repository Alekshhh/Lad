using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class Rally : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Rally) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.knockBack = 2.5f;
				item.crit = 6;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Rally) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to get dazzled on hit");
                tooltips.Add(line1);
			}
		}
	}
}