using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class TombCrawler : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.TombCrawlerHead && npc.type == NPCID.TombCrawlerBody && npc.type == NPCID.TombCrawlerTail) {
				npc.lifeMax = 100;
			}
			if (npc.type == NPCID.TombCrawlerHead) {
				npc.damage = 25;
				npc.defense = 0;
			}
			if (npc.type == NPCID.TombCrawlerBody) {
				npc.damage = 12;
				npc.defense = 4;
			}
			if (npc.type == NPCID.TombCrawlerTail) {
				npc.damage = 8;
				npc.defense = 8;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.TombCrawlerHead && npc.type == NPCID.TombCrawlerBody && npc.type == NPCID.TombCrawlerTail) {
				npc.lifeMax = 140;
			}
			if (npc.type == NPCID.TombCrawlerHead) {
				npc.damage = 42;
				npc.defense = 3;
			}
			if (npc.type == NPCID.TombCrawlerBody) {
				npc.damage = 18;
				npc.defense = 8;
			}
			if (npc.type == NPCID.TombCrawlerTail) {
				npc.damage = 12;
				npc.defense = 14;
			}
		}
	}
}