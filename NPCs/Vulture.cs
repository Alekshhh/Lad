using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class Vulture : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.Vulture) {
                npc.damage = 25;
				npc.defense = 6;
				npc.lifeMax = 30;
				npc.knockBackResist = 0.9f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.Vulture) {
				npc.damage = 35;
				npc.defense = 8;
				npc.lifeMax = 50;
				npc.knockBackResist = 0.8f;
			}
		}
		
		public override void NPCLoot(NPC npc) {
			if (npc.type == NPCID.Vulture) {
				if(Main.rand.NextFloat() < .2000f) Item.NewItem(npc.getRect(), ItemID.Feather);
				else if(Main.expertMode && Main.rand.NextFloat() < .2500f) Item.NewItem(npc.getRect(), ItemID.Feather, Main.rand.Next(1,3));
			}
		}
	}
}