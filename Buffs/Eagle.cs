using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Buffs {
	public class Eagle : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Screaming Eagle");
            Description.SetDefault("Hoo-wah!");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			canBeCleared = false;
		}
		
		public override void Update(Player player, ref int buffIndex) {
            player.statDefense += 8;
			player.noKnockback = true;
		}
	}
}