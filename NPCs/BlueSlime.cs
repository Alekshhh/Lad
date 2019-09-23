using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.NPCs {
    public class BlueSlime : ModNPC {
		
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blue Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}
		
		public override void SetDefaults() {
			npc.width = 32;
			npc.height = 22;
			npc.damage = 10;
			npc.defense = 1;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 80;
			npc.knockBackResist = 0.9f;
			npc.aiStyle = 1;
			npc.alpha = 60;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			banner = Item.NPCtoBanner(NPCID.BlueSlime);
			bannerItem = Item.BannerToItem(banner);
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.damage = 20;
			npc.defense = 3;
			npc.lifeMax = 45;
			npc.value = 100;
			npc.knockBackResist = 0.8f;
			
			if (Main.hardMode) {
				npc.damage = 45;
				npc.defense = 15;
				npc.lifeMax = 120;
				npc.knockBackResist = 0;
				npc.value = 120;
			}
			
			if (NPC.downedPlantBoss) {
				npc.damage = 80;
				npc.defense = 25;
				npc.lifeMax = 360;
				npc.knockBackResist = 0;
				npc.value = 200;
			}
		}
		
		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, 103);
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.dayTime && !Main.slimeRain && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneBeach && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneRain && !spawnInfo.player.ZoneSandstorm && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneDungeon) {
				return SpawnCondition.OverworldDay.Chance * 0.8f;
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