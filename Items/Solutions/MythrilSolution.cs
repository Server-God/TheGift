using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Solutions
{
	public class MythrilSolution : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mythril Solution";
			item.shoot = mod.ProjectileType("MythrilSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 2, 50, 0);
			item.rare = 4;
			item.maxStack = 999;
			item.toolTip = "Used by the Clentaminator";
			item.toolTip2 = "Transmutes Stone into Mythril";
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			/*recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);*/
			recipe.AddIngredient(ItemID.MythrilOre,10);
			recipe.AddIngredient(null,"MineralSolution");
			recipe.SetResult(this, 1);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}
}
