using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items
{
	public class Magic : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "The Magic Touch";
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.toolTip = "Make special items with this.";
			item.value = 1;
			item.rare = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.GoldBar, 150);
		recipe.AddIngredient(ItemID.PlatinumCoin, 30);
		recipe.AddTile(null, "DeathBench");
		recipe.SetResult(this);
recipe.AddRecipe();
		}
   }
}
		