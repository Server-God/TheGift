using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.NPCs.Solution
{
	public class Terraformer : ModNPC
	{
		/*public override bool Autoload(ref string name, ref string texture)/*, ref string[] altTextures)
		{
			name = "Terraformer";
			return mod.Properties.Autoload;
		}*/

		public override void SetDefaults()
		{
			npc.name = "Terraformer";
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 40;
			npc.defense = 35;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 50;
			animationType = NPCID.Guide;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("RockSolution"));
			}
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			for (int k = 0; k < 255; k++)
			{
				Player player = Main.player[k];
				if (player.active)
				{
					for (int j = 0; j < player.inventory.Length; j++)
					{
						if (player.inventory[j].type == ItemID.Clentaminator || 
							player.inventory[j].type == mod.ItemType("Magic"))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		public override bool CheckConditions(int left, int right, int top, int bottom)
		{
			return true;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Sam";
				case 1:
					return "Robin";
				case 2:
					return "Valerie";
				default:
					return "Cassandra";
			}
		}

		public override void FindFrame(int frameHeight)
		{
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat()
		{
			int steam = NPC.FindFirstNPC(NPCID.Steampunker);
			if (steam >= 0 && Main.rand.Next(6) == 0)
			{
				return "I think me and " + Main.npc[steam].displayName + " are a lot alike.";
			}
			switch (Main.rand.Next(5))
			{
				case 0:
					return "Filling solutions are dangerous if misused. Please be careful.";
				case 1:
					return "Come to buy some terraforming tools?";
				case 2:
					return "There are some solutions too expensive for me to sell. You're free to try and make them yourself.";
				case 3:
					return "Feel free to buy whatever you like. Just don't come by complaining if you don't know how to use them properly.";
				default:
					return "Mineral solution is expensive, but totally worth it. You can even combine it with ores and gems to increase potency.";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28];
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.GreenSolution);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.RedSolution);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.PurpleSolution);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BlueSolution);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.DarkBlueSolution);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("JungleSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("IceSpreadSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("IceRemoveSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("GraniteSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("MarbleSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("RockNormalizerSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("ClaySolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("RockSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("DirtSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("WaterSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("LavaSolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("HoneySolution"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("MineralSolution"));
			nextSlot++;
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 6000;
			knockback = 400f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 1;
			randExtraCooldown = 2;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 603;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 120f;
			randomOffset = 20f;
		}
	}
}