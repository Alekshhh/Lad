using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class StylistScissors : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.StylistKilLaKillScissorsIWish) { // Need the if statement for specified weapon!
				item.damage = 8;
				item.autoReuse = true;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.StylistKilLaKillScissorsIWish) target.AddBuff(mod.BuffType("Bleed"), 60); // 60 frames = 1 second.
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.StylistKilLaKillScissorsIWish) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
			}
		}
	}
}