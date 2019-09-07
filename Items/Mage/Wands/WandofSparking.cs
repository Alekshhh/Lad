using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class WandofSparking : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.WandofSparking) {
				item.knockBack = 1;
				item.damage = 6;
			}
		}
	}
}