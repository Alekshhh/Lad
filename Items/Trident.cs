using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class Trident : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Trident) { // Need the if statement for specified weapon!
				item.damage = 10;
				item.useTime = 32;
				item.useAnimation = 32;
				item.knockBack = 4.5f;
			}
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Trident) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Has a chance for enemies to suffocate on hit");
                tooltips.Add(line2);
			}
		}
	}
}