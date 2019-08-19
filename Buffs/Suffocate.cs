using Terraria;
using Terraria.ModLoader;

namespace Lad.Buffs {
	public class Suffocate : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Drowned Lungs");
            Description.SetDefault("Your lungs are full of water");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		// This is the debuff itself.
		public override void Update(NPC npc, ref int buffIndex) {
			if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
				npc.lifeRegen -= 9;
				Dust.NewDust(npc.position, npc.width, npc.height, 33); // Makes the target emit particles.
			npc.GetGlobalNPC<LadNPC>(mod).suffocate = true;
		}
	}
}