using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class Muramasa : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Muramasa) { // Need the if statement for specified weapon!
				item.damage = 16;
				item.useTime = 16;
				item.useAnimation = 16;
				item.crit = 11;	
			}
		}
		
		public override void HoldItem(Item item, Player player) { // Adds buffs while held.
            if (item.type == ItemID.Muramasa) player.AddBuff(BuffID.WaterCandle, 0);
        }
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit) {
			if (item.type == ItemID.Muramasa) {
				player.AddBuff(mod.BuffType("Bloodlust"), 180); // 60 frames = 1 second.
			}
		}
		
		public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult, ref float flat) {
			if (item.type == ItemID.Muramasa) {
				if (player.FindBuffIndex(mod.BuffType("Bloodlust")) > -1) add += 0.2f;
			}
		}
		
		public override void GetWeaponCrit(Item item, Player player, ref int crit) {
			if (item.type == ItemID.Muramasa) {
				if (player.FindBuffIndex(mod.BuffType("Bloodlust")) > -1) crit += 10;
			}
		}
				
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Muramasa) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "It calls for fresh wounds...");
                tooltips.Add(line1);
			}
		}
	}
}