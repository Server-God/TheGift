using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.NPCs
{
	public class Elephant : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Futuristic Elephant";
			npc.displayName = "Elephant";
			npc.width = 40;
			npc.height = 40;
			npc.defense = 6;
			npc.lifeMax = 2000;
			npc.value = 60f;
			npc.aiStyle = 3;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Venom] = true;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.5f : 0f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void NPCLoot()  //Npc drop
        {
            if (Main.rand.Next(100) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Ivory"), 5); //Item spawn
            }

        }
	}
}
