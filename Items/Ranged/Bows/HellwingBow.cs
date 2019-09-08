using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class HellwingBow : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.HellwingBow) { // Need the if statement for specified weapon!
				item.damage = 10;
				item.autoReuse = true;
				item.useTime = 6;
				item.useAnimation = 6;
				item.crit = 6;
				item.knockBack = 1;
			}
		}
	}
}