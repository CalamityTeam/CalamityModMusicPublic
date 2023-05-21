using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("ExoMechsMusicboxItem")]
    public class ExoMechsMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.ExoMechsMusicBox>();
    }
}
