using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class MagicMissile : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.MagicMissile) {
				item.damage = 25;
				item.mana = 10;
				item.crit = 6;
				item.useTime = 20;
				item.useAnimation = 20;
				item.knockBack = 6;
				item.autoReuse = true;
			}
		}
		
		public override bool CanUseItem(Item item, Player player) {
			if (item.type == ItemID.MagicMissile) return player.ownedProjectileCounts[item.shoot] < 1;
			return true;
		}
	}
}