using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CeaselessVoidMusicbox")]
    public class CeaselessVoidMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CeaselessVoidMusicBox>();
    }
}
