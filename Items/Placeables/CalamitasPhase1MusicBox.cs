using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SCalGMusicbox")]
    public class CalamitasPhase1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasPhase1MusicBox>();
    }
}
