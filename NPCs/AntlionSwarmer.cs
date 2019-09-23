using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class AntlionSwarmer : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.FlyingAntlion) {
                npc.damage = 35;
				npc.defense = 1;
				npc.lifeMax = 40;
				npc.knockBackResist = 0.8f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.FlyingAntlion) {
				npc.damage = 60;
				npc.defense = 3;
				npc.lifeMax = 60;
				npc.knockBackResist = 0.6f;
			}
		}
	}
}