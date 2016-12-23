using System;
using Terraria;
using Terraria.ModLoader;

namespace TheGift.Buffs
{
    public class MinionBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Arma Minion";     
            Main.buffTip[Type] = "An Armanian Minion will fight for you";
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("MinionName")] > 0)
            {
                modPlayer.minionName = true;
            }
            if (!modPlayer.minionName)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}