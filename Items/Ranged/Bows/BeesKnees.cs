using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class BeesKnees : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.BeesKnees) { // Need the if statement for specified weapon!
				item.damage = 18;
				item.autoReuse = true;
				item.useTime = 26;
				item.useAnimation = 26;
			}
		}
	}
}