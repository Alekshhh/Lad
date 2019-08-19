using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class PurpleClubberfish : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.PurpleClubberfish) { // Need the if statement for specified weapon!
				item.damage = 28;
				item.useTime = 42;
				item.useAnimation = 42;
				item.knockBack = 6;
				item.autoReuse = false;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.PurpleClubberfish) target.AddBuff(BuffID.Stinky, 300); // 60 frames = 1 second.
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.PurpleClubberfish) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to stink on hit");
                tooltips.Add(line1);
			}
		}
	}
}