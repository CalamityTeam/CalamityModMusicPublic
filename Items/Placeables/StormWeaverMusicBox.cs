using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("StormWeaverMusicbox")]
    public class StormWeaverMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.StormWeaverMusicBox>();
    }
}
