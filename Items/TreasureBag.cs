using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items
{
    public class TreasureBag : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cool Treasure Bag";
            item.maxStack = 5;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.toolTip = "Right click to open";
            item.rare = 11;
            item.expert = true;      //add this if it's expert mode only
        }
        public override bool CanRightClick()
        {
            return true;
        }

       public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("WeaponFuel"), 15);
			player.QuickSpawnItem(mod.ItemType("KappaPotion"), 5);
			
		}
    }
}