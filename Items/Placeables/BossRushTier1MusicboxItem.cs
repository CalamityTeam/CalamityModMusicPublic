using Terraria.ModLoader;
using CalamityModMusic.Tiles;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    public class BossRushTier1MusicboxItem : ModItem
    {
        public override void SetStaticDefaults() => DisplayName.SetDefault("Music Box (Boss Rush - Tier 1)");

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<BossRushTier1Musicbox>();
            item.width = item.height = 24;
            item.rare = ItemRarityID.LightRed;
            item.value = 100000;
            item.accessory = true;
        }
    }
}
