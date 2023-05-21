using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BoomerDukeMusicbox")]
    public class OldDukeMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.OldDukeMusicBox>();
    }
}
