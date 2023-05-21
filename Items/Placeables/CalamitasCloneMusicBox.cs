using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CalamitasMusicbox")]
    public class CalamitasCloneMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasCloneMusicBox>();
    }
}
