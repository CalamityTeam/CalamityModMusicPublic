using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier1MusicboxItem")]
    public class BossRushTier1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier1MusicBox>();
    }
}
