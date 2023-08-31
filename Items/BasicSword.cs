using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace newworld.Items
{
	public class BasicSword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.newworld.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40000;
			Item.height = 40000;
			Item.useTime = 1;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 600;
			Item.value = 10000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}