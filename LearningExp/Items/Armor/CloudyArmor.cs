using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LearningExp.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CloudyArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cloudy Armor");
			Tooltip.SetDefault("You feel wet"
				+ "\nImmunity to 'On Fire!'"
				+ "\nConstant 'Feather Fall' effect");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buff[BuffID.FeatherFall] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(itemID.Cloud, 50);
			recipe.AddTile(tileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
