using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class IceSlime : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.IceSlime) {
                npc.damage = 12;
				npc.defense = 1;
				npc.lifeMax = 30;
				npc.knockBackResist = 0.75f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.IceSlime) {
				npc.damage = 16;
				npc.defense = 3;
				npc.lifeMax = 45;
				npc.knockBackResist = 0.6f;
			}
		}
		
		public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit) {
			if (npc.type == NPCID.IceSlime && Main.expertMode) target.AddBuff(BuffID.Frostburn, 30);
		}
	}
}