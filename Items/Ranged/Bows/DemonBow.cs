using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class DemonBow : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.DemonBow) { // Need the if statement for specified weapon!
				item.damage = 14;
				item.autoReuse = true;
				item.useTime = 28;
				item.useAnimation = 28;
			}
		}

		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.DemonBow && type == ProjectileID.WoodenArrowFriendly) {
				Projectile.NewProjectile(player.Center, new Vector2(speedX,speedY), mod.ProjectileType("CustomCursed"), item.damage + 4, 3, player.whoAmI);
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.DemonBow) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Replaces wooden arrows with cursed arrows");
                tooltips.Add(line1);
			}
		}
	}
}