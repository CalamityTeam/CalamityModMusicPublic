using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SCalAMusicbox")]
    public class CalamitasDefeatMusicBox : ModItem
    {
        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.CalamitasDefeatMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
			CreateRecipe().
				AddIngredient(ItemID.MusicBox).
				AddIngredient(ModContent.ItemType<CalamitasPhase1MusicBox>()).
				AddIngredient(ModContent.ItemType<CalamitasPhase2MusicBox>()).
				AddIngredient(ModContent.ItemType<CalamitasPhase3MusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                AddCustomShimmerResult(ItemID.MusicBox).
                Register();
        }
    }
}
