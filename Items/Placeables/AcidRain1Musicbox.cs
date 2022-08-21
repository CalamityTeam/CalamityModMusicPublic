using CalamityModMusic.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class AcidRain1Musicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Acidic Downpour)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<AcidRain1MusicboxTile>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            Mod calamity = CalamityModMusic.Instance.calamity;
			if (calamity != null)
			{
				CreateRecipe().
					AddIngredient(ItemID.MusicBox).
					AddIngredient(calamity.Find<ModItem>("Acidwood").Type, 10).
					AddIngredient(calamity.Find<ModItem>("SulphuricScale").Type, 10).
					AddIngredient(calamity.Find<ModItem>("CorrodedFossil").Type, 10).
					AddIngredient(calamity.Find<ModItem>("RuinousSoul").Type).
					AddTile(TileID.LunarCraftingStation).
					Register();
			}
        }
    }
}
