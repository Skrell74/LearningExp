using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LearningExp.Items.Armor
{
	[AutoloadEquip(EquipType.Helmet)]
	public class CloudyVisor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cloudy Visor");
			Tooltip.SetDefault("We swear that you'll hit...something."
				+ "\nImmunity to 'On Fire!'"
				+ "\nConstant 'Feather Fall' effect");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 2;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buff[BuffID.FeatherFall] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(itemID.Cloud, 20);
			recipe.AddTile(tileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
