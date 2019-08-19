using System.Collections.Generic; // Need this for the tooltip.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Lad.Items {
	public class LightsBane : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.LightsBane) { // Need the if statement for specified weapon!
				item.damage = 14;
				item.useTime = 16;
				item.useAnimation = 16;
				item.knockBack = 4;
				item.autoReuse = true;
				item.crit = 6;
			}
		}
		
		public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockback, bool crit) { // Adds on-hit effects.
			if (item.type == ItemID.LightsBane) target.AddBuff(BuffID.CursedInferno, 90); // 60 frames = 1 second.
		}
			
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) { // This code adds tooltips.
            if (item.type == ItemID.LightsBane) {
                TooltipLine line1 = new TooltipLine(mod, "Damage", "Causes enemies burn with cursed inferno on hit");
                tooltips.Add(line1);
			}
		}
		
		public override void MeleeEffects(Item item, Player player, Rectangle hitbox) {
			if (item.type == ItemID.LightsBane) {
				if (Main.rand.NextBool(3)) {
					int dustIndex = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 75, 0, 0, 0, default(Color), 3f);
					Main.dust[dustIndex].noGravity = true;
				}
			}
		}
	}
}