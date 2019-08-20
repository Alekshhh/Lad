using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Yoyos {
	public class WoodenYoyo : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.WoodYoyo) { // Need the if statement for specified weapon!
				item.damage = 6;
				item.knockBack = 2f;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.WoodYoyo) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "It's biodegradable! That's good, right?");
                tooltips.Add(line1);
			}
		}
	}
}