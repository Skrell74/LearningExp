using Terraria;
using Terraria.ModLoader;

namespace LearningExp.Items.Acessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class Fevvers : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Looking at these wings gives you sharp flashbacks to a darker time");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 1000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 30;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 1.5f;
			acceleration *= 5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(itemID.Feather, 25);
			recipe.AddIngredient(itemID.Mud, 5);
			recipe.AddTile(tileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
