using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad {
    class Lad : Mod {
        public Lad() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FlintlockPistol);
			recipe.AddIngredient(ItemID.IllegalGunParts);
			recipe.AddIngredient(ItemID.RedPaint, 5);
			recipe.AddIngredient(ItemID.GreenPaint, 5);
			recipe.AddIngredient(ItemID.BluePaint, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.PainterPaintballGun);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddIngredient(ItemID.Daybloom);
			recipe.AddIngredient(ItemID.Torch, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WandofSparking);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.WaterBucket);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(ItemID.WaterBolt);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.WarmthPotion, 5);
			recipe.AddIngredient(ItemID.Shiverthorn, 3);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HandWarmer);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.AddIngredient(ItemID.Mushroom, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.LesserRestorationPotion);
			recipe.AddRecipe();
			
            List<Recipe> rec = Main.recipe.ToList();
            rec.Where(x => x.createItem.type == ItemID.AmethystStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.CopperBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Amethyst, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.AmethystStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.TopazStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.TinBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Topaz, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.TopazStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.SapphireStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.SilverBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Sapphire, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.SapphireStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.EmeraldStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.TungstenBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Emerald, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.EmeraldStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.RubyStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.GoldBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Ruby, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.RubyStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.DiamondStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.PlatinumBar, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Diamond, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.DiamondStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.AmberStaff).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.FossilOre, false);
                s.requiredItem[0].stack = 10;
				s.requiredItem[1].SetDefaults(ItemID.Amber, false);
                s.requiredItem[1].stack = 1;

                s.createItem.SetDefaults(ItemID.AmberStaff, false);
                s.createItem.stack = 1;
            });
			
			rec.Where(x => x.createItem.type == ItemID.RestorationPotion).ToList().ForEach(s => {
                for (int i = 0; i < s.requiredItem.Length; i++) s.requiredItem[i] = new Item();

                s.requiredItem[0].SetDefaults(ItemID.LesserRestorationPotion, false);
                s.requiredItem[0].stack = 1;
				s.requiredItem[1].SetDefaults(ItemID.GlowingMushroom, false);
                s.requiredItem[1].stack = 3;

                s.createItem.SetDefaults(ItemID.RestorationPotion, false);
                s.createItem.stack = 1;
            });
			
            Main.recipe = rec.ToArray();
            Array.Resize(ref Main.recipe, Recipe.maxRecipes);
		}
	}
}