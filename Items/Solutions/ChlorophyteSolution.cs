using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Solutions
{
	public class ChlorophyteSolution : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chlorophyte Solution";
			item.shoot = mod.ProjectileType("ChlorophyteSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 4;
			item.maxStack = 999;
			item.toolTip = "Used by the Clentaminator";
			item.toolTip2 = "Transmutes Mud into Chlorophyte";
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			/*recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);*/
			recipe.AddIngredient(ItemID.ChlorophyteOre,10);
			recipe.AddIngredient(null,"MineralSolution");
			recipe.SetResult(this, 1);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}
}
