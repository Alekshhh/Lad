using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class TendonBow : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.TendonBow) { // Need the if statement for specified weapon!
				item.damage = 12;
				item.autoReuse = true;
				item.useTime = 32;
				item.useAnimation = 32;
			}
		}

		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.TendonBow && type == ProjectileID.WoodenArrowFriendly) {
				Projectile.NewProjectile(player.Center, new Vector2(speedX,speedY), mod.ProjectileType("CustomLife"), item.damage + 4, 3, player.whoAmI);
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.TendonBow) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Replaces wooden arrows with life-leeching arrows");
                tooltips.Add(line1);
			}
		}
	}
}