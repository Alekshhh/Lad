using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
    public class BallOHurt : GlobalItem { // Specific to items.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.BallOHurt) {
                item.damage = 18;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.BallOHurt) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn with cursed inferno on hit");
                tooltips.Add(line1);
			}
		}
	}
}