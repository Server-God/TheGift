using Terraria;
using Terraria.ModLoader;

namespace TheGift.Items
{
	public class ElementResidue : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Elemental Residue";
			item.width = 20;
			item.height = 20;
			item.toolTip = "Reacts in a strange way with Luminite";
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}
	}
}