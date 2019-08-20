using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
	public class BeeKeeper : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.BeeKeeper) { // Need the if statement for specified weapon!
				item.damage = 30;
				item.useTime = 18;
				item.useAnimation = 18;
				item.knockBack = 6;
			}
		}
	}
}