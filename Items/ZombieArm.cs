using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class ZombieArm : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.ZombieArm) { // Need the if statement for specified weapon!
				item.damage = 14;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.ZombieArm && Main.rand.NextFloat() < .2500f) target.AddBuff(BuffID.Poisoned, 180); // 60 frames = 1 second.
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.ZombieArm) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to poison enemies on hit");
                tooltips.Add(line1);
			}
		}
	}
}