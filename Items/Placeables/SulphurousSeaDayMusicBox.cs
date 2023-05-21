using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SulphurousMusicbox")]
    public class SulphurousSeaDayMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.SulphurousSeaDayMusicBox>();
    }
}
