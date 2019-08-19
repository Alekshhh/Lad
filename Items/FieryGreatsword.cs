using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class FieryGreatsword : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.FieryGreatsword) { // Need the if statement for specified weapon!
				item.damage = 46;
				item.useTime = 34;
				item.useAnimation = 34;
				item.knockBack = 8;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.FieryGreatsword) target.AddBuff(BuffID.OnFire, 300); // 60 frames = 1 second.
			if (item.type == ItemID.FieryGreatsword){
			if (Main.rand.NextFloat() < .3333f)	target.AddBuff(mod.BuffType("Melting"), 180); // 60 frames = 1 second.
			}
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
			if (item.type == ItemID.FieryGreatsword) {
				TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to melt enemies on hit"); // This code adds tooltips.
                tooltips.Add(line1);
				foreach (TooltipLine line2 in tooltips) { // This code changes existing tooltips.
					if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "Causes enemies to burn on hit";
				}
			}
		}
	}
}