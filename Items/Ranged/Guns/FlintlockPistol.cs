using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Guns {
	public class FlintlockPistol : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.FlintlockPistol) { // Need the if statement for specified weapon!
				item.damage = 16;
				item.useTime = 24;
				item.useAnimation = 24;
			}
		}
	}
}