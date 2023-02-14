using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier5MusicboxItem")]
    public class BossRushTier5MusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            //SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Boss Rush - Tier 5)"); // Unobtainable.
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
            Item.createTile = ModContent.TileType<Tiles.BossRushTier5MusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
