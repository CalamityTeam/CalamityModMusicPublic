using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("DoGP2Musicbox")]
    public class DevourerofGodsPhase2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.DevourerofGodsPhase2MusicBox>();
    }
}
