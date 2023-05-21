using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CrabulonMusicbox")]
    public class CrabulonMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CrabulonMusicBox>();
    }
}
