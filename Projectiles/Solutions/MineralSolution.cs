using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Projectiles.Solutions
{
	public class MineralSolution : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.name = "Mineral Spray";
			projectile.width = 6;
			projectile.height = 6;
			projectile.friendly = true;
			projectile.alpha = 255;
			projectile.penetrate = -1;
			projectile.extraUpdates = 2;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}

		public override void AI()
		{
			int dustType = mod.DustType("MineralSolution");
			if (projectile.owner == Main.myPlayer){
				/*Player p = Main.player[Main.myPlayer];
				float xCenter = projectile.position.X + (float)(projectile.width / 2);
				float yCenter = projectile.position.Y + (float)(projectile.height / 2);
				float pxCenter = p.position.X + (float) (p.width / 2);
				float pyCenter = p.position.Y + (float)(p.height / 2);
				double distance = Math.Sqrt((xCenter - pxCenter) *(xCenter - pxCenter) +  (yCenter - pyCenter) *(yCenter - pyCenter));
				
				if(distance > 128)*/
					Convert((int)(projectile.position.X + (float)(projectile.width / 2)) / 16, (int)(projectile.position.Y + (float)(projectile.height / 2)) / 16, 2);
			}
			if (projectile.timeLeft > 63)
			{
				projectile.timeLeft = 63;
			}
			if (projectile.ai[0] > 7f)
			{
				float dustScale = 1f;
				if (projectile.ai[0] == 8f)
				{
					dustScale = 0.2f;
				}
				else if (projectile.ai[0] == 9f)
				{
					dustScale = 0.4f;
				}
				else if (projectile.ai[0] == 10f)
				{
					dustScale = 0.6f;
				}
				else if (projectile.ai[0] == 11f)
				{
					dustScale = 0.8f;
				}
				projectile.ai[0] += 1f;
				for (int i = 0; i < 1; i++)
				{
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, dustType, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
					Dust dust = Main.dust[dustIndex];
					dust.noGravity = true;
					dust.scale *= 1.75f;
					dust.velocity.X = dust.velocity.X * 2f;
					dust.velocity.Y = dust.velocity.Y * 2f;
					dust.scale *= dustScale;
				}
			}
			else
			{
				projectile.ai[0] += 1f;
			}
			projectile.rotation += 0.3f * (float)projectile.direction;
		}

		public void Convert(int i, int j, int size = 4)
		{
			for (int k = i - size; k <= i + size; k++)
			{
				for (int l = j - size; l <= j + size; l++)
				{
					if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
					{
						int type = (int)Main.tile[k, l].type;
						/*if (wall == 0)
						{
							Main.tile[k, l].wall = 1;
							WorldGen.SquareWallFrame(k, l, true);
							NetMessage.SendTileSquare(-1, k, l, 1);
						}*/
						
						/*if (type == 0 && Main.tile[k, l].active() || type == 2 || type == 23 || type == 109 || type == 199)*/
						
						if(type == 1 || type == 25 ||type == 117|| type == 203){
							int chance = Main.rand.Next(100);
							if(chance < 20){
								chance = Main.rand.Next(100);
								if(chance < 50){
									if(Main.rand.Next(2) == 0){
										Main.tile[k, l].type = 66;
									}else{
										Main.tile[k, l].type = 67;
									}
								}else if (chance < 90){
									switch(Main.rand.Next(3)){
									case 0:
											Main.tile[k, l].type = 63;
											break;
									case 1:
											Main.tile[k, l].type = 64;
											break;
									default:
											Main.tile[k, l].type = 65;
											break;
									}
								}else{
									Main.tile[k, l].type = 68;
								}
							}else if (chance >= 70 && Main.hardMode && WorldGen.oreTier1 != -1){
								chance = Main.rand.Next(100);
								if (chance >= 85 && WorldGen.oreTier3 != -1){
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.oreTier3 == 111)? 223 : 111);
									}else{
										Main.tile[k, l].type = (ushort)WorldGen.oreTier3;
									}
								}else if(chance < 35 && WorldGen.oreTier2 != -1){
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.oreTier2 == 108)? 222 : 108);
									}else{
										Main.tile[k, l].type = (ushort)WorldGen.oreTier2;
									}	
								}else{
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.oreTier1 == 107)? 221 : 107);
									}else{
										Main.tile[k, l].type = (ushort)WorldGen.oreTier1;
									}
								}
							}else{
								chance = Main.rand.Next(100);
								if (chance >= 85){
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.GoldTierOre == 8)? 169: 8);
									}else{
										Main.tile[k, l].type = WorldGen.GoldTierOre;
									}
								}else if(chance >= 65){
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.SilverTierOre == 9) ? 168 : 9);
									}else{
										Main.tile[k, l].type = WorldGen.SilverTierOre;
									}	
								}else if(chance >= 40){
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.IronTierOre == 6)? 167 : 6);
									}else{
										Main.tile[k, l].type = WorldGen.IronTierOre;
									}	
								}else{
									if(Main.rand.Next(5) == 0){
										Main.tile[k, l].type = (ushort)((WorldGen.CopperTierOre == 7) ? 166 : 7);
									}else{
										Main.tile[k, l].type = WorldGen.CopperTierOre;
									}
								}
							}
							WorldGen.SquareTileFrame(k, l, true);
							NetMessage.SendTileSquare(-1, k, l, 1);
						}
						
						
						
					}
				}
			}
		}
	}
}
