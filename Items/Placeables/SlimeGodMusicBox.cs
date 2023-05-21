using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SlimeGodMusicbox")]
    public class SlimeGodMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.SlimeGodMusicBox>();
    }
}
