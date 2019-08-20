using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Flails {
    public class Meatball : GlobalItem { // Specific to items.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.TheMeatball) {
                item.damage = 16;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.TheMeatball) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Siphons life from enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}