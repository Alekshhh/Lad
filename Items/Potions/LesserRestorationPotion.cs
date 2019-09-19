using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class LesserRestorationPotion : GlobalItem {
		public override void SetDefaults(Item item) {
            if (item.type == ItemID.LesserRestorationPotion) {
				item.buffTime = 1200;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.LesserRestorationPotion) {
                TooltipLine line1 = new TooltipLine(mod, "Consumable", "Grants temporary mana and health regeneration");
                tooltips.Add(line1);
			}
		}
		
		public override bool UseItem(Item item, Player player) {
			if (item.type == ItemID.LesserRestorationPotion) {
				player.AddBuff(BuffID.Regeneration, 1200);
				player.AddBuff(BuffID.ManaRegeneration, 1200);
			}
           return true;
		}
	}
}