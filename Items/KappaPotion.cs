using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
 
namespace TheGift.Items
{
    public class KappaPotion : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Kappa Potion";
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.toolTip = "Incresed defense by 100, life regen, melee damage and inferno buff";
            item.value = 10000;                
            item.rare = 1;
            item.buffType = mod.BuffType("KillEm");    //this is where you put your Buff
            item.buffTime = 20000;    //this is the buff duration        20000 = 6 min
            return;
        }
		
		

    }
}