using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SunkenSeaMusicbox")]
    public class SunkenSeaMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.SunkenSeaMusicBox>();
    }
}
