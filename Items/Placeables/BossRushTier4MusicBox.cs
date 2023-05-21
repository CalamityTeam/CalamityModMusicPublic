using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier4MusicboxItem")]
    public class BossRushTier4MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier4MusicBox>();
        public override bool Obtainable => false;
    }
}
