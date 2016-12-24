using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGift.Items.Placeable
{
	public class Acorn : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Derpacorn";
			item.width = 40;
			item.height = 40;
			item.maxStack = 99;
			AddTooltip("Grows Derp!");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DerpSapling");
			
		}

	}
}