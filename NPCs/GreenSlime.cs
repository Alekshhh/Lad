using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
    public class GreenSlime : ModNPC {
		
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Green Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}
		
		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 22;
			npc.damage = 6;
			npc.defense = 0;
			npc.lifeMax = 20;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 40;
			npc.knockBackResist = 0.9f;
			npc.aiStyle = 1;
			npc.alpha = 60;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			banner = Item.NPCtoBanner(NPCID.GreenSlime);
			bannerItem = Item.BannerToItem(banner);
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.damage = 15;
			npc.defense = 1;
			npc.lifeMax = 30;
			npc.value = 60;
			npc.knockBackResist = 0.8f;
			
			if (Main.hardMode) {
				npc.damage = 35;
				npc.defense = 12;
				npc.lifeMax = 100;
				npc.knockBackResist = 0;
				npc.value = 100;
			}
			
			if (NPC.downedPlantBoss) {
				npc.damage = 60;
				npc.defense = 20;
				npc.lifeMax = 300;
				npc.knockBackResist = 0;
				npc.value = 100;
			}
		}
		
		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 2);
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.dayTime && !Main.slimeRain && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneBeach && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneRain && !spawnInfo.player.ZoneSandstorm && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneDungeon) {
				return SpawnCondition.OverworldDay.Chance * 1f;
			}
			return 0;
		}
		
		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), ItemID.Gel);
			if(Main.expertMode && Main.rand.NextFloat() < .5000f) Item.NewItem(npc.getRect(), ItemID.Gel);
			if (Main.rand.NextFloat() < .0100f) Item.NewItem(npc.getRect(), ItemID.SlimeStaff);
		}
	}
}