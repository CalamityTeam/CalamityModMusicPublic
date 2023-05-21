using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AbyssLowerMusicbox")]
    public class AbyssLayer3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLayer3MusicBox>();
    }
}
