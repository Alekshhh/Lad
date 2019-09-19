using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Accessories {
	public class WarmthPotion : GlobalItem {
		public override void SetDefaults(Item item) {
            if (item.type == ItemID.WarmthPotion) {
                item.buffTime = 18000;
			}
		}
	}
}