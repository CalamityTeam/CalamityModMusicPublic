using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SirenMusicbox")]
    public class AnahitaMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AnahitaMusicBox>();
    }
}
