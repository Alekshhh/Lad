using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items {
	public class SwordsShortswords : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == 6 || item.type == 3483 || item.type == 3489 || item.type == 3495 || item.type == 3501 || item.type == 3507 || item.type == 3513 || item.type == 3519) { // Need the if statement for specified weapon!
				item.autoReuse = true;
				item.useTime = 16;
				item.useAnimation = 16;
			}
				
			if (item.type == ItemID.CopperShortsword || item.type == ItemID.TinShortsword) {
				item.damage = 6;
			}
			
			if (item.type == ItemID.IronShortsword || item.type == ItemID.LeadShortsword) {
				item.damage = 8;
			}
			
			if (item.type == ItemID.SilverShortsword || item.type == ItemID.TungstenShortsword) {
				item.damage = 10;
			}
			
			if (item.type == ItemID.GoldShortsword || item.type == ItemID.PlatinumShortsword) {
				item.damage = 12;
			}
			
			if (item.type == ItemID.CopperBroadsword || item.type == ItemID.TinBroadsword) {
				item.damage = 10;
			}
			
			if (item.type == ItemID.IronBroadsword || item.type == ItemID.LeadBroadsword) {
				item.damage = 12;
			}
			
			if (item.type == ItemID.SilverBroadsword || item.type == ItemID.TungstenBroadsword) {
				item.damage = 14;
			}
			
			if (item.type == ItemID.GoldBroadsword || item.type == ItemID.PlatinumBroadsword) {
				item.damage = 16;
			}
		}
	}
}