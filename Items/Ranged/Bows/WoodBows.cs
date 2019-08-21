using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Bows {
	public class WoodBows : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.WoodenBow) { // Need the if statement for specified weapon!
				item.damage = 2;
				item.useTime = 28;
				item.useAnimation = 28;
			}
			
			if (item.type == ItemID.BorealWoodBow || item.type == ItemID.RichMahoganyBow || item.type == ItemID.PalmWoodBow) {
				item.damage = 4;
				item.useTime = 26;
				item.useAnimation = 26;
			}
			
			if (item.type == ItemID.ShadewoodBow || item.type == ItemID.EbonwoodBow) {
				item.damage = 6;
				item.useTime = 26;
				item.useAnimation = 26;
			}
			
			if (item.type == ItemID.CopperBow || item.type == ItemID.TinBow) {
				item.damage = 8;
				item.useTime = 24;
				item.useAnimation = 24;
			}
			
			if (item.type == ItemID.IronBow || item.type == ItemID.LeadBow) {
				item.damage = 10;
				item.useTime = 24;
				item.useAnimation = 24;
			}
			
			if (item.type == ItemID.SilverBow || item.type == ItemID.TungstenBow) {
				item.damage = 12;
				item.useTime = 24;
				item.useAnimation = 24;
			}
			
			if (item.type == ItemID.GoldBow || item.type == ItemID.PlatinumBow) {
				item.damage = 14;
				item.useTime = 26;
				item.useAnimation = 26;
			}
		}
	}
}