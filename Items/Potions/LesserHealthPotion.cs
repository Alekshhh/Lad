using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class LesserHealingPotion : GlobalItem {
		public override void SetDefaults(Item item) {
            if (item.type == ItemID.LesserHealingPotion) {
                item.maxStack = 50;
			}
		}
	}
}