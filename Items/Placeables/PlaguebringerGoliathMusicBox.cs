using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("PlaguebringerMusicbox")]
    public class PlaguebringerGoliathMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PlaguebringerGoliathMusicBox>();
    }
}
