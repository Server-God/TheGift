using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift
{
	public class MyPlayer : ModPlayer
	{
		private const int saveVersion = 0;
		public int score = 0;
		public bool eFlames = false;
		public bool elementShield = false;
		public int elementShields = 0;
		private int elementShieldTimer = 0;
		public int elementShieldPos = 0;
		public int lockTime = 0;
		public bool voidMonolith = false;
		public int heroLives = 0;
		public int reviveTime = 0;
		public int constantDamage = 0;
		public float percentDamage = 0f;
		public float defenseEffect = -1f;
		public bool badHeal = false;
		public int healHurt = 0;
		public bool nullified = false;
		public int purityDebuffCooldown = 0;
		public bool examplePet = false;
		public bool exampleLightPet = false;
		public bool minionName = false;
        public static bool hasProjectile;

		public bool ZoneExample = false;

		public override void ResetEffects()
		{
			eFlames = false;
			elementShield = false;
			constantDamage = 0;
			percentDamage = 0f;
			defenseEffect = -1f;
			badHeal = false;
			healHurt = 0;
			nullified = false;
			examplePet = false;
			exampleLightPet = false;
			minionName = false;
		}

		public override void UpdateDead()
		{
			eFlames = false;
			badHeal = false;
		}


		public override void SetupStartInventory(IList<Item> items)
		{
			Item item = new Item();
			item.SetDefaults(mod.ItemType("GlitchLordSword"));
			item.stack = 1;
			item.SetDefaults(mod.ItemType("MinionS"));
			item.stack = 1;
			items.Add(item);
			
		}


		public override bool CustomBiomesMatch(Player other)
		{
			MyPlayer modOther = other.GetModPlayer<MyPlayer>(mod);
			return ZoneExample == modOther.ZoneExample;
		}

		public override void CopyCustomBiomesTo(Player other)
		{
			MyPlayer modOther = other.GetModPlayer<MyPlayer>(mod);
			modOther.ZoneExample = ZoneExample;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			byte flags = 0;
			if (ZoneExample)
			{
				flags |= 1;
			}
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			byte flags = reader.ReadByte();
			ZoneExample = ((flags & 1) == 1);
		}



		public override void AnglerQuestReward(float quality, List<Item> rewardItems)
		{
			if (voidMonolith)
			{
				Item sticky = new Item();
				sticky.SetDefaults(ItemID.StickyDynamite);
				sticky.stack = 4;
				rewardItems.Add(sticky);
			}
			foreach (Item item in rewardItems)
			{
				if (item.type == ItemID.GoldCoin)
				{
					int stack = item.stack;
					item.SetDefaults(ItemID.PlatinumCoin);
					item.stack = stack;
				}
			}
		}

		public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
		{
			if (eFlames)
			{
				if (Main.rand.Next(4) == 0 && drawInfo.shadow == 0f)
				{
					int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, mod.DustType("EtherealFlame"), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default(Color), 3f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					Main.playerDrawDust.Add(dust);
				}
				r *= 0.1f;
				g *= 0.2f;
				b *= 0.7f;
				fullBright = true;
			}
		}




	}
}
