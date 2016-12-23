using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Solutions
{
	public class ClaySolution : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dirt-to-Clay Solution";
			item.shoot = mod.ProjectileType("ClaySolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.toolTip = "Used by the Clentaminator";
			item.toolTip2 = "Turns regular Dirt into Clay";
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
