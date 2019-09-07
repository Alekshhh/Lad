using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class Vilethorn : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.Vilethorn) {
				item.knockBack = 1.5f;
				item.damage = 8;
				item.mana = 10;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.Vilethorn) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to get poisoned on hit");
                tooltips.Add(line1);
				TooltipLine line2 = new TooltipLine(mod, "Damage", "Causes enemies to get envenomed on direct tip hits");
                tooltips.Add(line2);
			}
		}
	}
}