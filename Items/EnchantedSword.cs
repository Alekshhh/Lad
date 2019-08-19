using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
    public class EnchantedSword : GlobalItem { // Specific to items.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.EnchantedSword) {
                item.damage = 18;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.EnchantedSword) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to get dazzled on hit.");
                tooltips.Add(line1);
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.EnchantedSword) target.AddBuff(mod.BuffType("Dazzle"), 180); // 60 frames = 1 second.
		}
	}
}