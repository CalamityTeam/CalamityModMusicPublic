using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SCalAMusicbox")]
    public class CalamitasDefeatMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasDefeatMusicBox>();

        public override void AddRecipes()
        {
			CreateRecipe().
				AddIngredient(ItemID.MusicBox).
				AddIngredient(ModContent.ItemType<CalamitasPhase1MusicBox>()).
				AddIngredient(ModContent.ItemType<CalamitasPhase2MusicBox>()).
				AddIngredient(ModContent.ItemType<CalamitasPhase3MusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}
