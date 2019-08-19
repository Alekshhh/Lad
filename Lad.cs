using Terraria.ModLoader;
using Terraria.ID;

namespace Lad {
    class Lad : Mod {
        public Lad() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
		
		public override void AddRecipes() { // I'm sorry for what you're about to witness
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
		}
	}
}