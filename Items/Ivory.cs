using Terraria.ID;
using Terraria.ModLoader;
   
namespace TheGift.Items
{
	public class Ivory : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Ivory";
			item.width = 40;
			item.height = 40;
			item.maxStack = 1000000;
			item.toolTip = "Now with futuristics qualities!";
			item.value = 1500;
			item.rare = 13;
		}
   }
}
		