using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class AntlionCharger : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.WalkingAntlion) {
                npc.damage = 30;
				npc.defense = 3;
				npc.lifeMax = 50;
				npc.knockBackResist = 0.6f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.WalkingAntlion) {
				npc.damage = 45;
				npc.defense = 5;
				npc.lifeMax = 80;
				npc.knockBackResist = 0.45f;
			}
		}
	}
}