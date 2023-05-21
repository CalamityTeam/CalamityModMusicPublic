using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SignusMusicbox")]
    public class SignusMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.SignusMusicBox>();
    }
}
