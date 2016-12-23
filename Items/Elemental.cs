using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TheGift.Items
{
	public class Elemental : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Elemental";
			item.width = 24;
			item.height = 24;
			item.toolTip = "Comes from the moon, partly.";
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 9;
			item.damage = 120;
			item.magic = false;
		}

		public override DrawAnimation GetAnimation()
		{
			return new DrawAnimationVertical(10, 4);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "ElementResidue");
		recipe.AddIngredient(ItemID.LunarBar);
		recipe.AddTile(null, "DeathBench");
		recipe.SetResult(this);
		recipe.AddRecipe();
		}
	}
}