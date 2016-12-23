using Terraria;
using Terraria.ModLoader;

namespace TheGift.Items
{
	//imported from my tAPI mod because I'm lazy
	public class PurityTotem : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Purity Totem";
			item.damage = 110000000;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.toolTip = "Summons a purity wisp to fight for you.";
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.shoot = mod.ProjectileType("PurityWispP");
			item.shootSpeed = 10000f;
			item.buffType = mod.BuffType("PurityWisp");
			item.buffTime = 3600;
		}
	}
}