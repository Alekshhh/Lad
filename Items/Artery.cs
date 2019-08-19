using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class Artery : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.CrimsonYoyo) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.knockBack = 2;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.CrimsonYoyo) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Siphons life from enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}