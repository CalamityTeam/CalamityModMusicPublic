using Terraria.ModLoader;
using CalamityModMusic.Tiles;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    public class BossRushTier4MusicboxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Boss Rush - Tier 4)"); // Unobtainable.
            Tooltip.SetDefault("This music box is unfinished and does not work");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<BossRushTier4Musicbox>();
            Item.width = Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
