using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Buffs
{
    public class WeaponBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffName[this.Type] = "Cool life regen";
            Main.buffTip[this.Type] = "Raidly Regen Life";
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //this buff will increase melee damage and life regen
            player.AddBuff(mod.BuffType("KillEm"), 1); //this is an example of how to add your own buff
            player.AddBuff(BuffID.Thorns, 2);
			player.AddBuff(BuffID.WeaponImbueConfetti, 1);
        }
    }
}