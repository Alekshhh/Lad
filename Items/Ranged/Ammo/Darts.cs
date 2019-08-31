using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Ammo {
	public class Darts : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.PoisonDart) {
				item.damage = 6;
				item.knockBack = 1;
				item.shootSpeed = 1;
			}
			
			if (item.type == ItemID.CrystalDart) {
				item.damage = 8;
				item.knockBack = 1;
			}
			
			if (item.type == ItemID.CursedDart) {
				item.damage = 10;
				item.knockBack = 2;
				item.shootSpeed = 5;
			}
			
			if (item.type == ItemID.IchorDart) {
				item.damage = 6;
				item.knockBack = 0.5f;
			}
		}
	}
}
