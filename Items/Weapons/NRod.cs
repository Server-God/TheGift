using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items.Weapons
{
	public class NRod : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Nuclear Rod";
			item.damage = 998000000;
			item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Protecting nature doesn't matter when your this OP! Atomic Number 92";
			item.useTime = 1;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 74;
			item.value = 99999990;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("PurityBeam");  //javelin projectile
            item.shootSpeed = 80f; 
			item.useTurn = true;
			item.maxStack = 92;       
            item.consumable = true;  
            item.noUseGraphic = true;
		}
		
   }
}
		