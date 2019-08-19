using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class IceBoomerang : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.IceBoomerang) { // Need the if statement for specified weapon!
				item.damage = 12;
			}
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.IceBoomerang) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn with frostburn on hit");
                tooltips.Add(line1);
			}
		}
	}
}