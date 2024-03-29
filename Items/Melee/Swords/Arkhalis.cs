using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
	public class Arkhalis : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Arkhalis) { // Need the if statement for specified weapon!
				item.damage = 3;
				item.useTime = 20;
				item.useAnimation = 20;
				item.knockBack = 3.5f;
				item.crit = 21;
			}
		}
	}
}