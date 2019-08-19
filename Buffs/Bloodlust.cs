using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Buffs {
	public class Bloodlust : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Bloodlust");
            Description.SetDefault("Fueled by the flow of blood");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			canBeCleared = false;
		}
	}
}