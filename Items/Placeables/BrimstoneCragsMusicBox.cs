using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CragMusicbox")]
    public class BrimstoneCragsMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BrimstoneCragsMusicBox>();
    }
}
