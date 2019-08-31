using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Guns {
	public class Minishark : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Minishark) { // Need the if statement for specified weapon!
				item.damage = 4;
				item.crit = 6;
				item.useTime = 10;
				item.useAnimation = 10;
			}
		}
	}
}