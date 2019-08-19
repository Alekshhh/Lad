using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class BloodButcherer : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.BloodButcherer) { // Need the if statement for specified weapon!
				item.damage = 20;
				item.autoReuse = true;
				item.useTime = 26;
				item.useAnimation = 26;
				item.knockBack = 6;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.BloodButcherer) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Siphons life from enemies on hit");
                tooltips.Add(line1);
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.BloodButcherer) {
// This line checks targets that aren't Target Dummies AND critters. Very useful! Thank you Uncle Danny!
// Note to self: || = OR, && = AND.
				if (target.type != NPCID.TargetDummy && target.CanBeChasedBy(item, false)) {
					int healingAmount = damage/8; // This code grants lifesteal.
					player.statLife +=healingAmount;
					player.HealEffect(healingAmount, true);
				}
			}
		}
	}
}