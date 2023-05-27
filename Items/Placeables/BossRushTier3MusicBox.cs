using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier3MusicboxItem")]
    public class BossRushTier3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier3MusicBox>();
    }
}
