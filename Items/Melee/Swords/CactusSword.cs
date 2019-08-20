using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
    public class CactusSword : GlobalItem { // Specific to items.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.CactusSword) {
                item.damage = 6;
				item.useTime = 28;
				item.useAnimation = 28;
			}
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.CactusSword) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to bleed on hit");
                tooltips.Add(line1);
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.CactusSword) target.AddBuff(mod.BuffType("Bleed"), 180); // 60 frames = 1 second.
		}
	}
}