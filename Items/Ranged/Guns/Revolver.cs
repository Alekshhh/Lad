using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Guns {
	public class Revolver : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.Revolver) { // Need the if statement for specified weapon!
				item.damage = 10;
				item.crit = 11;
			}
		}

		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.Revolver && type == ProjectileID.Bullet) {
				Projectile.NewProjectile(player.Center, new Vector2(speedX,speedY), ProjectileID.BulletHighVelocity, item.damage + 6, 3, player.whoAmI);
				return false;
			}
			return true;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.Revolver) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Replaces musket balls with high velocity bullets");
                tooltips.Add(line1);
			}
		}
	}
}