using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class Flamelash : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.Flamelash) {
				item.damage = 50;
				item.mana = 15;
				item.useTime = 28;
				item.useAnimation = 28;
				item.knockBack = 8;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.Flamelash) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to melt enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}