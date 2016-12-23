using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.NPCs
{
	public class TheNPC : ModNPC
	{
		public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
		{
			name = "The Cloudman";
			altTextures = new string[] { "TheGift/NPCs/TheNPC_Alt_1" };
			return mod.Properties.Autoload;
		}

		public override void SetDefaults()
		{
			npc.name = "The Cloudman";
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
			NPCID.Sets.ExtraTextureCount[npc.type] = 1;
			animationType = NPCID.Guide;
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
						if (player.inventory[j].type == mod.ItemType("WeaponFuel") || player.inventory[j].type == mod.ItemType("PurityTotem"))
						{
							return true;
						}
					}
				}
			}
			return false;
		}


		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Someone";
				case 1:
					return "Somebody";
				case 2:
					return "Blocky";
				default:
					return "Colorless";
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
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.Next(4) == 0)
			{
				return "Can you please tell " + Main.npc[partyGirl].displayName + " to stop decorating my house with colors?";
			}
			switch (Main.rand.Next(3))
			{
				case 0:
					return "Sometimes I feel like I'm different from everyone else here.";
				case 1:
					return "What's your favorite color? My favorite colors are blue and cyan.";
				default:
					return "What? I don't have any arms or legs? Oh, don't be ridiculous!";
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
			shop.item[nextSlot].SetDefaults(mod.ItemType("WeaponFuel"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.LunarBar);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("KappaPotion"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("TreasureBag"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Joystick"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("DeathBench"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("DerpSolution"));
			nextSlot++;
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 200000;
			knockback = 400f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 3;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("ConfettinP");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}