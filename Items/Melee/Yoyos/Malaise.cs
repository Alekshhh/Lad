using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Yoyos {
	public class Malaise : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.CorruptYoyo) { // Need the if statement for specified weapon!
				item.damage = 14;
				item.knockBack = 3.5f;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.CorruptYoyo) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn with cursed inferno on hit");
                tooltips.Add(line1);
			}
		}
	}
}