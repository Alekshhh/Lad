using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Yoyos {
	public class Valor : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Valor) { // Need the if statement for specified weapon!
				item.damage = 24;
				item.knockBack = 4f;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Valor) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Gain courage when in the face of danger");
                tooltips.Add(line1);
			}
		}
		
		public override void HoldItem(Item item, Player player) {
			if (item.type == ItemID.Valor) {
				player.GetModPlayer<LadPlayer>(mod).eagle = true;
			}
		}
		
		public override void GetWeaponCrit(Item item, Player player, ref int crit) {
			if (item.type == ItemID.Muramasa) {
				if (player.FindBuffIndex(mod.BuffType("Eagle")) > -1) crit += 6;
			}
		}
		
		public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult, ref float flat) {
			if (item.type == ItemID.Valor) {
				if (player.FindBuffIndex(mod.BuffType("Eagle")) > -1) add += 0.2f;
			}
		}
	}
}