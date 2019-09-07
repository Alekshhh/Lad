using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Mage.Wands {
	public class CrimsonRod : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.CrimsonRod) {
				item.damage = 15;
				item.mana = 20;
				item.crit = -4;
			}
		}
	}
}