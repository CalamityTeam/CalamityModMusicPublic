using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("PlaguebringerMusicbox")]
    public class PlaguebringerGoliathMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PlaguebringerGoliathMusicBox>();
    }
}
