using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AstralMusicbox")]
    public class AstralInfectionMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AstralInfectionMusicBox>();
    }
}
