using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier2MusicboxItem")]
    public class BossRushTier2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier2MusicBox>();
    }
}
