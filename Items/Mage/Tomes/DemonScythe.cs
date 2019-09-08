using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Tomes {
	public class DemonScythe : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.DemonScythe) {
				item.damage = 38;
				item.mana = 16;
				item.knockBack = 2;
				item.shootSpeed = 2;
				item.useTime = 28;
				item.useAnimation = 28;
				item.autoReuse = true;
			}
		}
	}
}