using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
	public class SpikedIceSlime : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.SpikedIceSlime) {
                npc.damage = 16;
				npc.defense = 3;
				npc.lifeMax = 48;
				npc.knockBackResist = 0.6f;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.SpikedIceSlime) {
				npc.damage = 28;
				npc.defense = 5;
				npc.lifeMax = 62;
				npc.knockBackResist = 0.5f;
			}
		}
		
		public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit) {
			if (npc.type == NPCID.SpikedIceSlime && Main.expertMode) target.AddBuff(BuffID.Frostburn, 30);
		}
	}
}