using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AstralUndergroundMusicbox")]
    public class AstralInfectionUndergroundMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AstralInfectionUndergroundMusicBox>();
    }
}
