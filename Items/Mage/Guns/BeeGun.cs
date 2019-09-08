using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Guns {
	public class BeeGun : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.BeeGun) {
				item.damage = 10;
				item.mana = 6;
				item.crit = 6;
			}
		}
	}
}