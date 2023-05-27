using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SirenIdleMusicbox")]
    public class AnahitasLureMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AnahitasLureMusicBox>();
    }
}
