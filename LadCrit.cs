using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad {
    public class LadCrit : GlobalItem {
		public override void GetWeaponCrit(Item item, Player player, ref int crit) {
			if (crit > 50) crit = 50;
		}
	}
}