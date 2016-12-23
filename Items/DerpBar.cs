using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items
{
	public class DerpBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Molten Bar of Derpiness";
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.toolTip = "Dripping with derpiness";
			item.value = 1;
			item.rare = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "DerpBlock", 6);
		recipe.AddTile(TileID.Furnaces);
		recipe.SetResult(this);
recipe.AddRecipe();
		}
   }
}