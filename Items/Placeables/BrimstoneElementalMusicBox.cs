using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BrimmyMusicbox")]
    public class BrimstoneElementalMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BrimstoneElementalMusicBox>();
    }
}
