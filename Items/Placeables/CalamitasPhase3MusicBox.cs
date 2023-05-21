using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SCalEMusicbox")]
    public class CalamitasPhase3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasPhase3MusicBox>();
    }
}
