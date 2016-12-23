using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items
{
    public class Joystick : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.name = "Retro Joystick";
            item.toolTip = "Summons Pac Man to follow you";
            item.shoot = mod.ProjectileType("PacManP");
            item.buffType = mod.BuffType("PacManBuff");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WeaponFuel", 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}