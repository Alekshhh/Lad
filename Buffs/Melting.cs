using Terraria;
using Terraria.ModLoader;

namespace Lad.Buffs {
	public class Melting : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Melting");
            Description.SetDefault("My skin is melting away!");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		// This is the debuff itself.
		public override void Update(NPC npc, ref int buffIndex) {
			if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
				npc.lifeRegen -= 20;
				Dust.NewDust(npc.position, npc.width, npc.height, 127); // Makes the target emit particles.
			npc.GetGlobalNPC<LadNPC>(mod).melt = true;
		}
	}
}