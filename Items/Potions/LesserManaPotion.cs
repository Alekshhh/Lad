using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class LesserManaPotion : GlobalItem {
		public override void SetDefaults(Item item) {
            if (item.type == ItemID.LesserManaPotion) {
                item.maxStack = 100;
			}
		}
	}
}