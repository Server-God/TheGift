using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items.Weapons
{
	public class TheConfettin: ModItem
	{
		public override void SetDefaults()
		{
			item.name = "The Confettin";
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is a staff made by the Amazing Peoples of The Earth, dubbed Sarah and Moses, take good care";
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 9999999;
			item.rare = 13;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.RocketFireworkBlue;
			item.shootSpeed = 150f;

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
recipe.AddIngredient(ItemID.GoldBar, 53);
recipe.AddIngredient(ItemID.BlueRocket, 19);
recipe.AddIngredient(null, "WeaponFuel", 10);
recipe.AddTile(TileID.WorkBenches);
recipe.SetResult(this);
recipe.AddRecipe();
		}
   }
}
		