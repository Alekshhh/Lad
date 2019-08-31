using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Spears {
	public class Swordfish : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Swordfish) { // Need the if statement for specified weapon!
				item.damage = 8;
				item.useTime = 20;
				item.useAnimation = 20;
				item.crit = 6;
				item.autoReuse = true;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Swordfish) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Has a chance for enemies to suffocate on hit");
                tooltips.Add(line2);
			}
		}
		
		public override bool CanUseItem(Item item, Player player) { // This code is needed for spears that have item.autoReuse = true.
			if (item.type == ItemID.Swordfish) return player.ownedProjectileCounts[item.shoot] < 1;
			return true;
		}
	}
}