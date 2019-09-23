using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
    public class PurpleSlime : ModNPC {
		
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Purple Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}
		
		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 22;
			npc.scale = 1.2f;
			npc.damage = 15;
			npc.defense = 3;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100;
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 1;
			npc.alpha = 60;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			banner = Item.NPCtoBanner(NPCID.PurpleSlime);
			bannerItem = Item.BannerToItem(banner);
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.damage = 25;
			npc.defense = 5;
			npc.lifeMax = 65;
			npc.value = 150;
			npc.knockBackResist = 0.4f;
			
			if (Main.hardMode) {
				npc.damage = 45;
				npc.defense = 18;
				npc.lifeMax = 150;
				npc.knockBackResist = 0;
				npc.value = 180;
			}
			
			if (NPC.downedPlantBoss) {
				npc.damage = 80;
				npc.defense = 30;
				npc.lifeMax = 400;
				npc.knockBackResist = 0;
				npc.value = 300;
			}
		}
		
		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 145);
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.dayTime && !Main.slimeRain && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneBeach && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneRain && !spawnInfo.player.ZoneSandstorm && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneDungeon) {
				return SpawnCondition.OverworldDay.Chance * 0.4f;
			}
			return 0;
		}
		
		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), ItemID.Gel ,2);
			if(Main.expertMode && Main.rand.NextFloat() < .5000f) Item.NewItem(npc.getRect(), ItemID.Gel);
			if (Main.rand.NextFloat() < .0100f) Item.NewItem(npc.getRect(), ItemID.SlimeStaff);
		}
	}
}