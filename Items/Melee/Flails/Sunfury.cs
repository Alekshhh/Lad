using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Flails {
	public class Sunfury : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Sunfury) { // Need the if statement for specified weapon!
				item.damage = 42;
				item.knockBack = 7.5f;
				item.crit = 0;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Sunfury) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn on hit");
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Has a chance for enemies to melt on hit");
                tooltips.Add(line2);
			}
		}
	}
}