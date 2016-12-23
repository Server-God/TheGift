using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Armor
{
    public class ivoryhelmet : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TurtleHelmet);
			item.name = "Ivory Helmet";
            item.toolTip = "";
            item.toolTip2 = "x50 ranged damage.";
            item.value = 10000;
            item.defense = 8000;
        }
		
		public override void UpdateEquip(Player player)
        {
		 player.rangedDamage *= 50f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ivoryarmor") && legs.type == mod.ItemType("ivorylegs");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.rangedDamage *= 50f;
			item.defense = 1500;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Ivory", 12);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}