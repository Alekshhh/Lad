using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Others {
	public class ReaverShark : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.ReaverShark) { // Need the if statement for specified weapon!
				item.damage = 20;
				item.pick = 55;
				item.useTime = 28;
				item.useAnimation = 28;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.ReaverShark) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "'Why do we fish, just to suffer?'");
                tooltips.Add(line1);
			}
		}
	}
}