using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Arrows {
	public class WoodBows : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.FlamingArrow || item.type == ItemID.FrostburnArrow || item.type == ItemID.JestersArrow) { // Need the if statement for specified weapon!
				item.damage = 4;
			}
			
			if (item.type == ItemID.WoodenArrow || item.type == ItemID.EndlessQuiver) {
				item.damage = 3;
			}
			
			if (item.type == ItemID.UnholyArrow) {
				item.damage = 6;
			}
			
			if (item.type == ItemID.HellfireArrow) {
				item.damage = 8;
			}
			
			if (item.type == ItemID.IchorArrow) {
				item.damage = 10;
			}
			
			if (item.type == ItemID.CursedArrow) {
				item.damage = 12;
			}
			
			if (item.type == ItemID.HolyArrow) {
				item.damage = 8;
			}
			
			if (item.type == ItemID.ChlorophyteArrow) {
				item.damage = 14;
			}
			
			if (item.type == ItemID.VenomArrow) {
				item.damage = 16;
			}
			
			if (item.type == ItemID.LuminiteArrow) {
				item.damage = 18;
			}
		}
	}
}
