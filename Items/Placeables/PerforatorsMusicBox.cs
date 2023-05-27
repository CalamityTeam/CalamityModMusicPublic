using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("PerforatorMusicbox")]
    public class PerforatorsMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PerforatorsMusicBox>();
    }
}
