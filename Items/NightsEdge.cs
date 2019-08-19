using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class NightsEdge : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.NightsEdge) { // Need the if statement for specified weapon!
				item.damage = 42;
				item.useTime = 24;
				item.useAnimation = 24;
				item.knockBack = 5;
				item.autoReuse = true;
				item.crit = 6;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.NightsEdge) target.AddBuff(BuffID.ShadowFlame, 120); // 60 frames = 1 second.
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.NightsEdge) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies burn with shadowflame on hit");
                tooltips.Add(line1);
			}
		}
	}
}