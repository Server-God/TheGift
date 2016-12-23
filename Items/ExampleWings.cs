using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace TheGift.Items
{
	public class ExampleWings : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Wings);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Amazing Wings";
			item.width = 22;
			item.height = 20;
			item.toolTip = "Wings of Amazingness";
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 1800;
		}

		public override void VerticalWingSpeeds(ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 15f;
			maxCanAscendMultiplier = 3f;
			maxAscentMultiplier = 5f;
			constantAscend = 5f;
		}

		public override void HorizontalWingSpeeds(ref float speed, ref float acceleration)
		{
			speed = 30f;
			acceleration *= 2f;
		}

	}
}