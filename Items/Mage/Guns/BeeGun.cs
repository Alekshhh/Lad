using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Guns {
	public class BeeGun : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.BeeGun) {
				item.damage = 12;
				item.mana = 6;
			}
		}
	}
}