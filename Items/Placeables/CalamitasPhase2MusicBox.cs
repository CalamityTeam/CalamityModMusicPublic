using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SCalLMusicbox")]
    public class CalamitasPhase2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasPhase2MusicBox>();
    }
}
