using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Flails {
	public class ChainKnife : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.ChainKnife) { // Need the if statement for specified weapon!
				item.damage = 8;
				item.knockBack = 3f;
				item.autoReuse = true;
				item.crit = 4;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.ChainKnife) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "'You don't belong in this world!'");
                tooltips.Add(line1);
			}
		}
	}
}