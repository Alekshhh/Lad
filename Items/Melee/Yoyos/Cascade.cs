using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Yoyos {
	public class Cascade : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Cascade) { // Need the if statement for specified weapon!
				item.damage = 20;
				item.knockBack = 4.5f;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Cascade) {
				TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn on hit");
                tooltips.Add(line1);
                TooltipLine line2 = new TooltipLine(mod, "Damage", "Spews molten lava at random");
                tooltips.Add(line2);
			}
		}
	}
}