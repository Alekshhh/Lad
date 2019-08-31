using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class MoltenFury : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.MoltenFury) { // Need the if statement for specified weapon!
				item.damage = 20;
				item.useTime = 30;
				item.useAnimation = 30;
			}
		}

		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.MoltenFury && type == ProjectileID.FireArrow) {
				Projectile.NewProjectile(player.Center, new Vector2(speedX,speedY), mod.ProjectileType("CustomBoom"), item.damage + 6, 8, player.whoAmI);
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.MoltenFury) {
				foreach (TooltipLine line2 in tooltips) { // This code changes existing tooltips.
					if (line2.mod == "Terraria" && line2.Name == "Tooltip0") line2.text = "Replaces wooden and flaming arrows with hellfire arrows";
				}
			}
		}
	}
}