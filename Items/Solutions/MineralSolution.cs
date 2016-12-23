using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Solutions
{
	public class MineralSolution : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mineral Solution";
			item.shoot = mod.ProjectileType("MineralSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.rare = 4;
			item.maxStack = 999;
			item.toolTip = "Used by the Clentaminator";
			item.toolTip2 = "Spreads random minerals from Stone";
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();*/
		}
	}
}
