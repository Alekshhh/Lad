using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Melee.Swords {
	public class Phaseblades : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == 198 || item.type == 199 || item.type == 200 || item.type == 201 || item.type == 202 || item.type == 203) { // Need the if statement for specified weapon!
				item.damage = 18;
				item.useTime = 18;
				item.useAnimation = 18;
				item.autoReuse = true;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == 198 || item.type == 199 || item.type == 200 || item.type == 201 || item.type == 202 || item.type == 203) target.AddBuff(BuffID.OnFire, 300); // 60 frames = 1 second.
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == 198 || item.type == 199 || item.type == 200 || item.type == 201 || item.type == 202 || item.type == 203) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies to burn on hit");
                tooltips.Add(line1);
			}
		}
	}
}