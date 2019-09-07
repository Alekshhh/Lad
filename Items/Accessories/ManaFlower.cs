using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class ManaFlower : GlobalItem {
		public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
			if (item.type == ItemID.ManaFlower) {
				player.GetModPlayer<LadPlayer>().manaFlowy = true;
			}
		}
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.ManaFlower) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "20% reduced magic damage");
                tooltips.Add(line1);
			}
		}
	}
}