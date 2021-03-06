using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Buffs
{
    public class KillEm : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffName[this.Type] = "Cool life regen";
            Main.buffTip[this.Type] = "Raidly Regen Life";
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //this buff will increase melee damage and life regen
            player.lifeRegen = +6000;
            // player.meleeDamage += .12;
			player.AddBuff(BuffID.Inferno, 1);
        }
    }
}