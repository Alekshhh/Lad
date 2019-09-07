using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Guns {
	public class SpaceGun : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.SpaceGun) {
				item.knockBack = 0;
				item.damage = 12;
				item.crit = -4;
				item.useTime = 16;
				item.useAnimation = 16;
				item.mana = 4;
			}
		}
	}
}