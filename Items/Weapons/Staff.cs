using Terraria;
using Terraria.ModLoader;

namespace TheGift.Items.Weapons
{
	public class Staff : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "The Staff";
			item.damage = 2000;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is overpowered?.";
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = false; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SparklingBall");
			item.shootSpeed = 56f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WeaponFuel", 5);
			recipe.AddIngredient(null, "Magic", 5);
			recipe.AddTile(null, "DeathBench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}