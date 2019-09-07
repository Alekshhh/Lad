using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class FlowerofFire : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.FlowerofFire) {
				item.knockBack = 4;
				item.damage = 32;
				item.mana = 12;
				item.autoReuse = true;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.FlowerofFire) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to melt enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}