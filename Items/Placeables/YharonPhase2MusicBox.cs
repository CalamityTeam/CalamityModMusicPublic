using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("Yharon3Musicbox")]
    public class YharonPhase2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.YharonPhase2MusicBox>();
    }
}
