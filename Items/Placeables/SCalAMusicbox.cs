using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class SCalAMusicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Acceptance)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.SCalAMusicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
			CreateRecipe().
				AddIngredient(ItemID.MusicBox).
				AddIngredient(ModContent.ItemType<SCalGMusicbox>()).
				AddIngredient(ModContent.ItemType<SCalLMusicbox>()).
				AddIngredient(ModContent.ItemType<SCalEMusicbox>()).
				AddTile(TileID.TinkerersWorkbench).
				Register();
        }
    }
}
