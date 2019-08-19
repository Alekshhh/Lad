using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Lad.Projectiles;

namespace Lad.Items {
	public class DarkLance : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.DarkLance) { // Need the if statement for specified weapon!
				item.damage = 18;
				item.useTime = 28;
				item.useAnimation = 28;
				item.crit = 4;
				item.autoReuse = true;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.DarkLance) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn with shadowflame on hit");
                tooltips.Add(line1);
			}
		}
		
		public override bool CanUseItem(Item item, Player player) { // This code is needed for spears that have item.autoReuse = true.
			if (item.type == ItemID.DarkLance) return player.ownedProjectileCounts[item.shoot] < 1;
			return true;
		}
	}
}