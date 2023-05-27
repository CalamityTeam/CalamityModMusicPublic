using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("Yharon2Musicbox")]
    public class YharonPhase1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.YharonPhase1MusicBox>();
    }
}
