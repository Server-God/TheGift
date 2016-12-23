using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Placeable
{
	public class DeathBench : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Death Workbench";
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			AddTooltip("Use this to create all of my items in The Gift");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150000000;
			item.createTile = mod.TileType("DeathBench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "DerpBlock", 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}