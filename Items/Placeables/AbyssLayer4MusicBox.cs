using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("VoidMusicbox")]
    public class AbyssLayer4MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLayer4MusicBox>();
    }
}
