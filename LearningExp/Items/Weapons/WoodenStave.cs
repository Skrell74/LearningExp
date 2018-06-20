using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LearningExp.Items.Weapons
{
	public class WoodenStave : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don't worry about where all that lumber went");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.mana = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SparklingBall");
			item.shootSpeed = 16f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 50);
			recipe.AddIngredient(itemID.Ruby, 1)
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
