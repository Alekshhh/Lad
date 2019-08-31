using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Ammo {
	public class Arrows : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.FlamingArrow || item.type == ItemID.FrostburnArrow) { // Need the if statement for specified weapon!
				item.damage = 4;
				item.knockBack = 1;
				item.shootSpeed = 3;
			}
			
			if (item.type == ItemID.JestersArrow) {
				item.damage = 4;
				item.knockBack = 1;
				item.shootSpeed = 1;
			}
			
			if (item.type == ItemID.WoodenArrow || item.type == ItemID.EndlessQuiver) {
				item.damage = 3;
				item.knockBack = 1;
			}
			
			if (item.type == ItemID.UnholyArrow) {
				item.damage = 6;
				item.knockBack = 2;
				item.shootSpeed = 4;
			}
			
			if (item.type == ItemID.BoneArrow) {
				item.shootSpeed = 3.5f;
			}
			
			if (item.type == ItemID.HellfireArrow) {
				item.damage = 8;
				item.knockBack = 4.5f;
				item.shootSpeed = 5;
			}
			
			if (item.type == ItemID.IchorArrow) {
				item.damage = 10;
				item.knockBack = 1.5f;
				item.shootSpeed = 3.5f;
			}
			
			if (item.type == ItemID.CursedArrow) {
				item.damage = 12;
				item.knockBack = 2;
				item.shootSpeed = 4;
			}
			
			if (item.type == ItemID.HolyArrow) {
				item.damage = 8;
				item.knockBack = 0;
				item.shootSpeed = 3;
			}
			
			if (item.type == ItemID.ChlorophyteArrow) {
				item.damage = 14;
				item.knockBack = 3;
				item.shootSpeed = 5;
			}
			
			if (item.type == ItemID.VenomArrow) {
				item.damage = 16;
				item.knockBack = 3.5f;
				item.shootSpeed = 4;
			}
			
			if (item.type == ItemID.MoonlordArrow) {
				item.damage = 18;
				item.knockBack = 3;
				item.shootSpeed = 6;
			}
		}
	}
}
