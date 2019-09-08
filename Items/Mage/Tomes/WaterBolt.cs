using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Tomes {
	public class WaterBolt : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.WaterBolt) {
				item.damage = 12;
				item.mana = 6;
				item.knockBack = 4;
				item.shootSpeed = 6;
				item.useTime = 24;
				item.useAnimation = 24;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.WaterBolt) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to suffocate on hit");
                tooltips.Add(line1);
			}
		}
	}
}