using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad {
    public class LadNPC : GlobalNPC {
		
		public override bool InstancePerEntity => true;
		
		public bool suffocate;
		public bool melt;
		
		public override void ResetEffects(NPC npc) {
			suffocate = false;
			melt = false;
		}
		
		public override void DrawEffects(NPC npc, ref Color drawColor) {
			if (suffocate) drawColor = Color.LightBlue;
			if (melt) drawColor = Color.Orange;
		}
			
		public override void SetDefaults(NPC npc) {
			npc.buffImmune[mod.BuffType("Bleed")] = npc.buffImmune[BuffID.Poisoned];
			npc.buffImmune[mod.BuffType("Suffocate")] = npc.buffImmune[BuffID.Poisoned];
			npc.buffImmune[mod.BuffType("Melting")] = npc.buffImmune[BuffID.OnFire];
		}
		
		public override void NPCLoot(NPC npc) {
// The code below checks where the player is. If they're in said location, enemies around them drop certain items.
// Thanks Yuyutsu!
			Player closest = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			if (closest.ZoneUnderworldHeight) {
				if (Main.rand.NextFloat() < .0100f) Item.NewItem(npc.getRect(), ItemID.Cascade);
			}
			if (npc.type == NPCID.Skeleton) {
				if (Main.rand.NextFloat() < .0500f) Item.NewItem(npc.getRect(), ItemID.BoneSword);
			}
			if (npc.type == NPCID.CaveBat) {
				if (Main.rand.NextFloat() < .0500f) Item.NewItem(npc.getRect(), ItemID.ChainKnife);
			}
		}
		
		public override void SetupShop(int type, Chest shop, ref int nextSlot) {
			if (type == NPCID.Clothier) {
				shop.item[nextSlot].SetDefaults(ItemID.BookofSkulls);
				shop.item[nextSlot].shopCustomPrice = 100000;
				nextSlot++;
			}
		}
	}
}