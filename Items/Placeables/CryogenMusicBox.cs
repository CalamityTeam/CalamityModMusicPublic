using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CryogenMusicbox")]
    public class CryogenMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CryogenMusicBox>();
    }
}
