using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Guns {
	public class PhoenixBlaster : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.PhoenixBlaster) { // Need the if statement for specified weapon!
				item.damage = 24;
				item.useTime = 20;
				item.useAnimation = 20;
				item.autoReuse = true;
			}
		}

		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.PhoenixBlaster && type == ProjectileID.Bullet) {
				Projectile.NewProjectile(player.Center, new Vector2(speedX,speedY), mod.ProjectileType("MeltBullet"), item.damage + 6, 3, player.whoAmI);
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.PhoenixBlaster) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Replaces musket balls with molten bullets that disappear quickly");
                tooltips.Add(line1);
			}
		}
	}
}