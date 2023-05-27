using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AcidRain2Musicbox")]
    public class AcidRainTier3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AcidRainTier3MusicBox>();
    }
}
