using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Boomers {
    public class ThornChakram : GlobalItem { // Specific to item attribute changes, like damage.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.ThornChakram) {
				item.damage = 24;
				item.shootSpeed = 14;
				item.knockBack = 6;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.ThornChakram) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to get poisoned on hit");
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Has a chance to envenom enemies on hit");
                tooltips.Add(line2);
			}
		}
	}
}