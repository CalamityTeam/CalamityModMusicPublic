using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("ProvidenceMusicbox")]
    public class ProvidenceMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.ProvidenceMusicBox>();
    }
}
