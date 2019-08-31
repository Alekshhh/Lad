using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Guns {
	public class Handgun : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Handgun) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.useTime = 14;
				item.useAnimation = 14;
				item.crit = 6;
				item.autoReuse = true;
			}
		}

		public override void HoldItem(Item item, Player player) {
			if (item.type == ItemID.Handgun) {
				player.GetModPlayer<LadPlayer>(mod).eagle2 = true;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Handgun) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Gain courage when in the face of danger");
                tooltips.Add(line1);
			}
		}
		
		public override void GetWeaponCrit(Item item, Player player, ref int crit) {
			if (item.type == ItemID.Handgun) {
				if (player.FindBuffIndex(mod.BuffType("Eagle")) > -1) crit += 5;
			}
		}
		
		public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult, ref float flat) {
			if (item.type == ItemID.Handgun) {
				if (player.FindBuffIndex(mod.BuffType("Eagle")) > -1) add += 0.4f;
			}
		}
	}
}