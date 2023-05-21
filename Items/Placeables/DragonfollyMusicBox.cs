using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BumblebirbMusicbox")]
    public class DragonfollyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.DragonfollyMusicBox>();
    }
}
