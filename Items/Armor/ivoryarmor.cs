using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Armor
{
    public class ivoryarmor : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TurtleScaleMail);
			item.name = "Ivory Armor";
            AddTooltip("Armor of a fallen elephant.");
            AddTooltip2("x50 ranged damage");
            item.value = 10;
            item.defense = 5000;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage *= 50f;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Ivory", 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}