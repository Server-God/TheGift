using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items.Weapons
{
	public class GlitchLordSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Glitch Lord Sword";
			item.damage = 75000000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.toolTip = "This is a sword made by the God, Itys, then given to Moses aka GlitchLord";
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 74;
			item.value = 10000000;
			item.autoReuse = true;
			item.useTurn = true;
			
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
recipe.AddIngredient(ItemID.FragmentSolar, 62);
recipe.AddIngredient(null, "WeaponFuel", 10);
recipe.AddTile(TileID.WorkBenches);
recipe.SetResult(this);
recipe.AddRecipe();
		}
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
	{
		player.AddBuff(mod.BuffType("WeaponBuff"), 400);
	}
   }
}
		