using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Others {
	public class PaintballGun : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.PainterPaintballGun) { // Need the if statement for specified weapon!
				item.damage = 6;
				item.crit = -4;
				item.autoReuse = true;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
			if (item.type == ItemID.PainterPaintballGun) {
				TooltipLine line1 = new TooltipLine(mod, "Damage", "woomy"); // This code adds tooltips.
                tooltips.Add(line1);
			}
		}
	}
}