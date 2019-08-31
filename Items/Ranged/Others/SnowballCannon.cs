using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Others {
	public class SnowballCannon : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Snowball) {
				item.damage = 4;
			}
			
			if (item.type == ItemID.SnowballCannon) {
				item.damage = 6;
			}
		}
	}
}