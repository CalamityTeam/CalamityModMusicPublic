using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BrimmyMusicbox")]
    public class BrimstoneElementalMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BrimstoneElementalMusicBox>();
    }
}
