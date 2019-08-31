using System; // for Math
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad {
    public class LadPlayer : ModPlayer {
        
        public bool eagle;
		public bool eagle2;
        
        public override void ResetEffects() {
            eagle = false;
			eagle2 = false;
        }
        
// This checks if an NPC is a set distance from the player. If it is within said distance (and the NPC is hostile), it adds a buff to the player until the NPC gets out of said distance.
// Thanks Yuyutsu!
        public override void PostUpdate() {
            if (eagle) {
				for (int i = 0; i < 200; i++) {
					int distance = (int)Math.Sqrt((Main.npc[i].Center.X - player.Center.X) * (Main.npc[i].Center.X - player.Center.X) + (Main.npc[i].Center.Y - player.Center.Y) * (Main.npc[i].Center.Y - player.Center.Y));
					if (distance < 180 && !Main.npc[i].friendly && Main.npc[i].type != NPCID.TargetDummy && Main.npc[i].active) player.AddBuff(mod.BuffType("Eagle"), 1);
				}
			}
			
			if (eagle2) {
				for (int i = 0; i < 200; i++) {
					int distance = (int)Math.Sqrt((Main.npc[i].Center.X - player.Center.X) * (Main.npc[i].Center.X - player.Center.X) + (Main.npc[i].Center.Y - player.Center.Y) * (Main.npc[i].Center.Y - player.Center.Y));
					if (distance < 320 && !Main.npc[i].friendly && Main.npc[i].type != NPCID.TargetDummy && Main.npc[i].active) player.AddBuff(mod.BuffType("Eagle"), 1);
				}
			}
		}
	}
}