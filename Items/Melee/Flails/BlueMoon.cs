using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Flails {
	public class BlueMoon : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.BlueMoon) { // Need the if statement for specified weapon!
				item.damage = 24;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.BlueMoon) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Make it rain, baby!");
                tooltips.Add(line1);
			}
		}
	}
}