using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items
{
	public class Defense : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Orb of the Defenses";
			item.width = 40;
			item.height = 40;
			item.maxStack = 1;
			item.toolTip = "Gives so much defense";
			item.value = 10000000;
			item.rare = 13;
			item.defense = 60000;
			item.accessory = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "DerpBar", 600);
		recipe.AddTile(null, "DeathBench");
		recipe.SetResult(this);
		recipe.AddRecipe();
		}
   }
}