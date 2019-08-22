using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Ranged.Bows {
	public class DemonBow : GlobalItem {
		public virtual bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (item.type == ItemID.DemonBow || item.ammo = ItemID.WoodenArrow;) item.shoot = mod.ProjectileType("CustomCursed");	
			return true; 
		}
	}
}