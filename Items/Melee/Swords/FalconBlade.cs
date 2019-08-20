using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items.Melee.Swords {
	public class FalconBlade : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.FalconBlade) { // Need the if statement for specified weapon!
				item.damage = 12;
			}
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.FalconBlade) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "'Show me your moves!'");
                tooltips.Add(line1);
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.FalconBlade) target.AddBuff(BuffID.OnFire, 180); // 60 frames = 1 second.
		}
		
		public override void MeleeEffects(Item item, Player player, Rectangle hitbox) {
			if (item.type == ItemID.FalconBlade) {
				if (Main.rand.NextBool(2)) {
					int dustIndex = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 127, 0, 0, 0, default(Color), 1.5f);
					Main.dust[dustIndex].noGravity = true;
				}
			}
		}
	}
}