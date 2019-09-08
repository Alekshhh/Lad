using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Tomes {
	public class BookofSkulls : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.BookofSkulls) {
				item.damage = 35;
				item.mana = 14;
				item.knockBack = 4;
				item.shootSpeed = 4;
				item.useTime = 32;
				item.useAnimation = 32;
				item.shoot = mod.ProjectileType("CustomDoot");
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.BookofSkulls) {
                foreach (TooltipLine line2 in tooltips) {
					if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "doot doot";
				}
			}
		}
	}
}