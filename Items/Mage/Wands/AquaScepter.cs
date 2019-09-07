using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class AquaScepter : GlobalItem {
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.AquaScepter) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to suffocate on hit");
                tooltips.Add(line1);
			}
		}
	}
}