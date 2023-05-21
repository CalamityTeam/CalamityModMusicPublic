using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AquaticScourgeMusicbox")]
    public class AquaticScourgeMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AquaticScourgeMusicBox>();
    }
}
