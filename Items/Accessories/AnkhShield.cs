using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class AnkhShield : GlobalItem {
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.AnkhShield) {
                foreach (TooltipLine line2 in tooltips) {
					if (line2.mod == "Terraria" && line2.Name == "Tooltip1") line2.text = "Grants immunity to the Bleeding, Broken Armor, Confused, Cursed, Darkness, Poisoned, Silenced, Slow and Weak debuffs";
				}
			}
		}
	}
}