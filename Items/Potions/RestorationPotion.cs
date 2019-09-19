using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class RestorationPotion : GlobalItem {
		public override void SetDefaults(Item item) {
            if (item.type == ItemID.RestorationPotion) {
				item.buffTime = 1200;
				item.healLife = 100;
				item.healMana = 100;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.RestorationPotion) {
                TooltipLine line1 = new TooltipLine(mod, "Consumable", "Grants temporary mana and health regeneration");
                tooltips.Add(line1);
			}
		}
		
		public override bool UseItem(Item item, Player player) {
			if (item.type == ItemID.RestorationPotion) {
				player.AddBuff(BuffID.Regeneration, 1200);
				player.AddBuff(BuffID.ManaRegeneration, 1200);
			}
           return true;
		}
	}
}