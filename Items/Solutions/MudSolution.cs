using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Solutions
{
	public class MudSolution : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Mud Filling Solution";
			item.shoot = mod.ProjectileType("MudSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.toolTip = "Used by the Clentaminator";
			item.toolTip2 = "Fills empty space with Mud";
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DirtSolution");
			recipe.AddTile(13);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}
