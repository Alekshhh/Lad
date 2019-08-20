using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
    public class Starfury : GlobalItem { // Specific to items.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.Starfury) {
                item.damage = 14;
				item.autoReuse = true;
				item.useTime = 24;
				item.useAnimation = 24;
			}
		}
	}
}