using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items
{
	public class WeaponFuel : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Illegal Weapon Fuel";
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.toolTip = "Can't get good weapons without this stuff";
			item.value = 1;
			item.rare = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.GoldBar, 1);
		recipe.AddIngredient(ItemID.PlatinumCoin, 3);
		recipe.AddTile(TileID.WorkBenches);
		recipe.SetResult(this);
recipe.AddRecipe();
		}
   }
}
		