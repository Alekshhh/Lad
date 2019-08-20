using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Spears {
	public class TheRottedFork : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.TheRottedFork) { // Need the if statement for specified weapon!
				item.autoReuse = true;
				item.damage = 12;
				item.knockBack = 6;
				item.useTime = 36;
				item.useAnimation = 36;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.TheRottedFork) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Siphons life from enemies on hit");
                tooltips.Add(line1);
			}
		}
		
		public override bool CanUseItem(Item item, Player player) { // This code is needed for spears that have item.autoReuse = true.
			if (item.type == ItemID.TheRottedFork) return player.ownedProjectileCounts[item.shoot] < 1;
			return true;
		}
	}
}