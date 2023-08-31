using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace newworld.Items
{
	public class YellowSign : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 24;
            Item.height = 28;
            Item.value = 10000;
            Item.rare = -1;
            Item.accessory = true;
		}

	}
}