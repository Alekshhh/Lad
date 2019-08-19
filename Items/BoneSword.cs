using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class BoneSword : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.BoneSword) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.autoReuse = true;
				item.useTime = 26;
				item.useAnimation = 26;
				item.crit = 4;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.BoneSword) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.BoneSword) target.AddBuff(mod.BuffType("Bleed"), 300); // 60 frames = 1 second.
		}
	}
}