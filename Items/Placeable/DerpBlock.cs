using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Placeable
{
	public class DerpBlock : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Block of Derp";
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			AddTooltip("No words could describe the derpiness of this block.");
			AddTooltip2("Can be used in extractinator to get magic");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DerpBlock");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;
		}


		public override void ExtractinatorUse(ref int resultType, ref int resultStack)
		{
			if (Main.rand.Next(30) == 0)
			{
				resultType = mod.ItemType("Magic");
				if (Main.rand.Next(5) == 0)
				{
					resultStack += Main.rand.Next(2);
				}
			}
		}
	}
}