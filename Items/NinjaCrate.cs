using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items
{
	public class NinjaCrate : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MasterNinjaGear);
			item.name = "Ninja Supply Crate";
			item.defense = 60000;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MasterNinjaGear);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddTile(TileID.AnnouncementBox);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}