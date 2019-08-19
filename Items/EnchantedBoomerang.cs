using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class EnchantedBoomerang : GlobalItem { 
		public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.EnchantedBoomerang) {
				item.crit = 6;
				item.damage = 10;
				item.shoot = mod.ProjectileType("CustomEnchanted");
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
			if (item.type == ItemID.EnchantedBoomerang) {
				TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to get dazzled on hit"); // This code adds tooltips.
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Has a chance to confuse enemies on hit");
                tooltips.Add(line2);
			}
		}
		
		public override bool CanUseItem(Item item, Player player) { // Makes a set amount of projectiles appear on screen at once
			if (item.type == ItemID.EnchantedBoomerang) return player.ownedProjectileCounts[item.shoot] < 2;
			return true;
		}
	}
}