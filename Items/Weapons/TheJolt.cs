using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items.Weapons
{
	public class TheJolt : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "The Jolt";
			item.damage = 18000000;
			item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is a sword made by the God, Itys, then given to Moses aka GlitchLord";
			item.useTime = 2;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 74;
			item.value = 9999999;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ConfettinP");  //javelin projectile
            item.shootSpeed = 8f; 
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
recipe.AddIngredient(ItemID.DiamondGemsparkBlock, 9);
recipe.AddIngredient(ItemID.BurningHadesDye);
recipe.AddIngredient(null, "WeaponFuel", 60);
recipe.AddTile(TileID.WorkBenches);
recipe.SetResult(this);
recipe.AddRecipe();
		}
   }
}
		