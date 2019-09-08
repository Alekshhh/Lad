using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Lad.Items.Mage.Wands {
	public class OreStaff : GlobalItem {
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.AmethystStaff || item.type == ItemID.TopazStaff) {
				item.damage = 12;
				item.mana = 4;
				item.useTime = 32;
				item.useAnimation = 32;
				item.autoReuse = false;
				item.knockBack = 3;
				item.shootSpeed = 6;
			}
			
			if (item.type == ItemID.SapphireStaff || item.type == ItemID.EmeraldStaff) {
				item.damage = 16;
				item.mana = 6;
				item.useTime = 30;
				item.useAnimation = 30;
				item.autoReuse = true;
				item.knockBack = 4;
				item.shootSpeed = 7;
			}
			
			if (item.type == ItemID.RubyStaff || item.type == ItemID.DiamondStaff) {
				item.damage = 18;
				item.mana = 8;
				item.useTime = 28;
				item.useAnimation = 28;
				item.autoReuse = true;
				item.knockBack = 5;
				item.shootSpeed = 8;
			}
			
			if (item.type == ItemID.AmberStaff) {
				item.damage = 14;
				item.mana = 10;
				item.useTime = 32;
				item.useAnimation = 32;
				item.autoReuse = true;
				item.knockBack = 6;
				item.shootSpeed = 10;
			}
		}
		
		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.AmberStaff) {
				float numberProjectiles = 3;
				float rotation = MathHelper.ToRadians(10);
				position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f;
				for (int i = 0; i < numberProjectiles; i++) {
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1)));
					Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				}
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            if (item.type == ItemID.AmberStaff) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Fires three amber bolts at once");
                tooltips.Add(line1);
			}
		}
	}
}