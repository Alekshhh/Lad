using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Buffs {
	public class Dazzle : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Dazzled");
            Description.SetDefault("The good ol' razzle dazzle");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		// This is the debuff itself.
		public override void Update(NPC npc, ref int buffIndex) {
			npc.defense -= 5;
			Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("DazzleDust")); // Makes the target emit custom particles.
		}
	}
}