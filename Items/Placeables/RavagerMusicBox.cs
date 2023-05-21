using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("RavagerMusicbox")]
    public class RavagerMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.RavagerMusicBox>();
    }
}
