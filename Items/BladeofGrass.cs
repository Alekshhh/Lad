using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
    public class BladeofGrass : GlobalItem { // Specific to item attribute changes, like damage.
        public override void SetDefaults(Item item) { // Need the if statement for specified weapon!
            if (item.type == ItemID.BladeofGrass) {
                item.damage = 24;
				item.useTime = 30;
				item.useAnimation = 30;
				item.knockBack = 6;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.BladeofGrass) target.AddBuff(BuffID.Poisoned, 300); // 60 frames = 1 second.
			// Gives the buff a chance to proc on hit.
			if (item.type == ItemID.BladeofGrass) {
				if (Main.rand.NextFloat() < .1500f) target.AddBuff(BuffID.Venom, 150);
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
			if (item.type == ItemID.BladeofGrass) {
				TooltipLine line1 = new TooltipLine(mod, "Damage", "Has a chance to envenom enemies on hit"); // This code adds tooltips.
                tooltips.Add(line1);
            foreach (TooltipLine line2 in tooltips) { // This code changes existing tooltips.
                if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "Causes enemies to get poisoned on hit";
				}
			}
		}
	}
}