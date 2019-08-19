using Terraria;
using Terraria.ModLoader;

namespace Lad.Buffs {
	public class Bleed : ModBuff {
	    public override void SetDefaults() {
			DisplayName.SetDefault("Bleeding Profusely");
            Description.SetDefault("Feeling lightheaded...");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		// This is the debuff itself.
		public override void Update(NPC npc, ref int buffIndex) {
			if (npc.lifeRegen > 0)
                npc.lifeRegen = 0;
				npc.lifeRegen -= 6;
				Dust.NewDust(npc.position, npc.width, npc.height, 5); // Makes the target emit particles.
		}
	}
}