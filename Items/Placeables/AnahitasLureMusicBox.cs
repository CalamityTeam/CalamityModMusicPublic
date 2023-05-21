using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SirenIdleMusicbox")]
    public class AnahitasLureMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AnahitasLureMusicBox>();
    }
}
