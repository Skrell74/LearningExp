using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LearningExp.Items.Weapons
{
	public class Crash : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crash()");
			Tooltip.SetDefault("Whispers from a long dead but not forgotten compainion escape from this blade's edge");
		}
		public override void SetDefaults()
		{
			item.damage = 64;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		//public override void AddRecipeGroup()
	//	{
		//	RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + "Transistor", new int[]
		//	{
		//		Crash
		//	});
	//		RecipeGroup.RegisterGroup("Transistor")
	//	}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 999);
			recipe.AddIngredient(ItemID.Ruby, 15);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
