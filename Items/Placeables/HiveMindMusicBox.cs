using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("HiveMindMusicbox")]
    public class HiveMindMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.HiveMindMusicBox>();
    }
}
