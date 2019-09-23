using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Thanks to Dominic K for allowing me to use his antlion projectile code!

namespace Lad.NPCs {
    public class Antlion : GlobalNPC {
		public override void SetDefaults(NPC npc) {
            if (npc.type == NPCID.Antlion) {
                npc.damage = 45;
				npc.defense = 5;
				npc.lifeMax = 60;
			}
		}
		
		public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale) {
			if (npc.type == NPCID.Antlion) {
				npc.damage = 75;
				npc.defense = 8;
				npc.lifeMax = 100;
			}
		}
		
        public override bool PreAI(NPC npc) {
            //antlion AI
            if (npc.aiStyle == 19)
            {
                //mostly cleaned up vanilla code. Shouldn't be too hard to understand
                npc.TargetClosest(true);
                bool rotationInRange = false;
                Player player = Main.player[npc.target];
                Vector2 distNormRelativeToPlayer = npc.DirectionTo(player.Center) * 12f;
                if (npc.directionY < 0)
                {
                    npc.rotation = distNormRelativeToPlayer.ToRotation() + MathHelper.PiOver2;
                    rotationInRange = ((double)npc.rotation >= -1.2 && (double)npc.rotation <= 1.2);
                    if ((double)npc.rotation < -0.8)
                    {
                        npc.rotation = -0.8f;
                    }
                    else if ((double)npc.rotation > 0.8)
                    {
                        npc.rotation = 0.8f;
                    }
                    if (npc.velocity.X != 0f)
                    {
                        npc.velocity.X = npc.velocity.X * 0.9f;
                        if ((double)npc.velocity.X > -0.1 || (double)npc.velocity.X < 0.1)
                        {
                            npc.netUpdate = true;
                            npc.velocity.X = 0f;
                        }
                    }
                }
                if (npc.ai[0] > 0f)
                {
                    if (npc.ai[0] == 200f)
                    {
                        Main.PlaySound(SoundID.Item5, npc.position);
                    }
                    npc.ai[0] -= 1f;
                }
                if ((Main.netMode != 1 & rotationInRange) && npc.ai[0] == 0f && Collision.CanHit(npc.position, npc.width, npc.height, Main.player[npc.target].position, Main.player[npc.target].width, Main.player[npc.target].height))
                {
                    npc.ai[0] = 200f;
                    int projectileDamage = 10;
                    int projectileIndex = Projectile.NewProjectile(npc.Top, distNormRelativeToPlayer, mod.ProjectileType("FallingSand"), projectileDamage, 0f, Main.myPlayer, 0f, 0f);
                    NetMessage.SendData(27, -1, -1, null, projectileIndex, 0f, 0f, 0f, 0, 0, 0);
                    npc.netUpdate = true;
                }
                try
                {
                    int positionTileX = (int)npc.position.X / 16;
                    int centerTileX = (int)(npc.position.X + (float)(npc.width / 2)) / 16;
                    int rightTileX = (int)(npc.position.X + (float)npc.width) / 16;
                    int bottomTileY = (int)(npc.position.Y + (float)npc.height) / 16;
                    bool tileBelow = false;
                    if (Main.tile[positionTileX, bottomTileY] == null)
                    {
                        Main.tile[positionTileX, bottomTileY] = new Tile();
                    }
                    if (Main.tile[centerTileX, bottomTileY] == null)
                    {
                        Main.tile[positionTileX, bottomTileY] = new Tile();
                    }
                    if (Main.tile[rightTileX, bottomTileY] == null)
                    {
                        Main.tile[positionTileX, bottomTileY] = new Tile();
                    }
                    if ((Main.tile[positionTileX, bottomTileY].nactive() && Main.tileSolid[(int)Main.tile[positionTileX, bottomTileY].type]) || (Main.tile[centerTileX, bottomTileY].nactive() && Main.tileSolid[(int)Main.tile[centerTileX, bottomTileY].type]) || (Main.tile[rightTileX, bottomTileY].nactive() && Main.tileSolid[(int)Main.tile[rightTileX, bottomTileY].type]))
                    {
                        tileBelow = true;
                    }
                    if (tileBelow)
                    {
                        npc.noGravity = true;
                        npc.noTileCollide = true;
                        npc.velocity.Y = -0.2f;
                    }
                    else
                    {
                        npc.noGravity = false;
                        npc.noTileCollide = false;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            return base.PreAI(npc);
        }
    }
}