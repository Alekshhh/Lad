using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class SandSlime : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.SandSlime) {
                npc.damage = 15	;
				npc.defense = 3;
				npc.lifeMax = 40;
				npc.knockBackResist = 0.9f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.SandSlime) {
				npc.damage = 35;
				npc.defense = 5;
				npc.lifeMax = 60;
				npc.knockBackResist = 0.8f;
			}
		}
		
		//public override void AI(NPC npc) {
			//if (npc.type == NPCID.SandSlime && Main.tile[tileX, tileY].type == TileID.Sand) npc.knockbackResist = 1;
			
		public override void NPCLoot(NPC npc) {
			if (npc.type == NPCID.SandSlime) {
				Item.NewItem(npc.getRect(), ItemID.SandBlock, Main.rand.Next(10,20));
				if (Main.rand.NextFloat() < .0100f) Item.NewItem(npc.getRect(), ItemID.SlimeStaff);
			}
		}
	}
}