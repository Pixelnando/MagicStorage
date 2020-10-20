﻿using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace MagicStorage.Items
{
	public class StorageUnitBlueChlorophyte : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Blue Chlorophyte Storage Unit");
			DisplayName.AddTranslation(GameCulture.Russian, "Синяя Хлорофитовая Ячейка Хранилища");
			DisplayName.AddTranslation(GameCulture.Polish, "Jednostka magazynująca (Niebieski Chlorofit)");
			DisplayName.AddTranslation(GameCulture.French, "Unité de stockage (Chlorophylle Bleu)");
			DisplayName.AddTranslation(GameCulture.Spanish, "Unidad de Almacenamiento (Clorofita Azul)");
			DisplayName.AddTranslation(GameCulture.Chinese, "存储单元(蓝色叶绿)");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.rare = ItemRarityID.Lime;
			item.value = Item.sellPrice(0, 1, 60);
			item.createTile = mod.TileType("StorageUnit");
			item.placeStyle = 5;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StorageUnitHallowed"));
			recipe.AddIngredient(mod.ItemType("UpgradeBlueChlorophyte"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
