using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AstrumDeusMusicbox")]
    public class AstrumDeusMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AstrumDeusMusicBox>();
    }
}
