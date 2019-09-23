using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class AngryTumbler : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.Tumbleweed) {
                npc.damage = 15;
				npc.defense = 0;
				npc.lifeMax = 20;
				npc.knockBackResist = 1;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.Tumbleweed) {
				npc.damage = 25;
				npc.defense = 3;
				npc.lifeMax = 35;
			}
		}
		
		public override void NPCLoot(NPC npc) {
			if (npc.type == NPCID.Tumbleweed) {
				int choice = Main.rand.Next(7);
				if (choice == 0 && Main.rand.NextFloat() < .5000f) Item.NewItem(npc.getRect(), ItemID.Amethyst, Main.rand.Next(2,4));
				else if (choice == 1 && Main.rand.NextFloat() < .5000f) Item.NewItem(npc.getRect(), ItemID.Topaz, Main.rand.Next(2,4));
				else if (choice == 2 && Main.rand.NextFloat() < .2500f) Item.NewItem(npc.getRect(), ItemID.Sapphire, Main.rand.Next(2,4));
				else if (choice == 3 && Main.rand.NextFloat() < .2500f) Item.NewItem(npc.getRect(), ItemID.Emerald, Main.rand.Next(2,4));
				else if (choice == 4 && Main.rand.NextFloat() < .1250f) Item.NewItem(npc.getRect(), ItemID.Ruby, Main.rand.Next(2,4));
				else if (choice == 5 && Main.rand.NextFloat() < .1250f) Item.NewItem(npc.getRect(), ItemID.Diamond, Main.rand.Next(2,4));
				else if (choice == 6 && Main.rand.NextFloat() < .0800f) Item.NewItem(npc.getRect(), ItemID.Amber, Main.rand.Next(2,4));
			}
		}
	}
}