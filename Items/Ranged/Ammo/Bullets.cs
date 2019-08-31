using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lad.Items.Ranged.Ammo {
	public class Bullets : GlobalItem {
		public override void SetDefaults(Item item) { // Specific to items.
			if (item.type == ItemID.MusketBall || item.type == ItemID.EndlessMusketPouch) {
				item.damage = 5;
				item.knockBack = 3;
				item.shootSpeed = 5;
			}
			
			if (item.type == ItemID.MeteorShot) {
				item.damage = 7;
				item.knockBack = 2.5f;
				item.shootSpeed = 6;
			}
			
			if (item.type == ItemID.SilverBullet || item.type == ItemID.PartyBullet) {
				item.damage = 8;
				item.knockBack = 3.5f;
				item.shootSpeed = 8;
			}
			
			if (item.type == ItemID.ExplodingBullet) {
				item.damage = 8;
				item.knockBack = 5;
				item.shootSpeed = 4;
			}
			
			if (item.type == ItemID.GoldenBullet) {
				item.damage = 6;
				item.knockBack = 3;
				item.shootSpeed = 12;
			}
			
			if (item.type == ItemID.CursedBullet) {
				item.damage = 10;
				item.knockBack = 4;
				item.shootSpeed = 10;
			}
			
			if (item.type == ItemID.IchorBullet) {
				item.damage = 8;
				item.knockBack = 2.5f;
				item.shootSpeed = 6;
			}
			
			if (item.type == ItemID.CrystalBullet) {
				item.damage = 4;
				item.knockBack = 2;
				item.shootSpeed = 8;
			}
			
			if (item.type == ItemID.HighVelocityBullet) {
				item.damage = 12;
				item.knockBack = 1.5f;
				item.shootSpeed = 10;
			}
			
			if (item.type == ItemID.ChlorophyteBullet) {
				item.damage = 10;
				item.knockBack = 1;
				item.shootSpeed = 8;
			}
			
			if (item.type == ItemID.VenomBullet) {
				item.damage = 14;
				item.knockBack = 4.5f;
				item.shootSpeed = 10;
			}
			
			if (item.type == ItemID.NanoBullet) {
				item.damage = 16;
				item.knockBack = 3;
				item.shootSpeed = 8;
			}
			
			if (item.type == ItemID.MoonlordBullet) {
				item.damage = 18;
				item.knockBack = 3;
				item.shootSpeed = 12;
			}
		}
	}
}