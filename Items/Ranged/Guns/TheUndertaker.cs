using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Guns {
	public class TheUndertaker : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.TheUndertaker) { // Need the if statement for specified weapon!
				item.damage = 2;
				item.useTime = 8;
				item.useAnimation = 40;
				item.reuseDelay = 0;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.TheUndertaker) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "'Rip and tear...'");
                tooltips.Add(line1);
			}
		}
	}
}