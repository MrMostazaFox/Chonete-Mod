using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChoneteMod.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class Chonete : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Chonete"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("¡Picha!");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.value = 1200;
			item.rare = 0;
			item.vanity = true;
		}

		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawAltHair = true;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2 );
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}