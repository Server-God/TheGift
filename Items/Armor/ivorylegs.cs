using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Armor
{
    public class ivorylegs : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TurtleLeggings);
			item.name = "Ivory Leggings";
            AddTooltip("");
			AddTooltip2("x50 ranged damage, +1050 increased movement speed");
            item.value = 10;
            item.defense = 1000;
        }

        public override void UpdateEquip(Player player)
        {
		 player.rangedDamage *= 50f;
         player.moveSpeed += 1050f;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Ivory", 72);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}