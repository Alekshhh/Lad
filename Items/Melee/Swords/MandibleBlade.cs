using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
	public class MandibleBlade : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.AntlionClaw) { // Need the if statement for specified weapon!
				item.damage = 10;
				item.useTime = 14;
				item.useAnimation = 14;
				item.knockBack = 3;
				item.crit = 4;
			}
		}
	}
}