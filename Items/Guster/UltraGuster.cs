using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items.Guster
{
	public class UltraGuster : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "ULTRA Guster";
			item.damage = 50000000;
			item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Ask Spencer Chapman to explain this";
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 10000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = ProjectileID.RainbowCrystal;
            item.shootSpeed = 8f; 
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.Ichor, 60);
			}
			else
			{
				target.AddBuff(BuffID.OnFire, 60);
			}
		}

   }
}
		