using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("LeviathanMusicbox")]
    public class LeviathanMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.LeviathanMusicBox>();
    }
}
