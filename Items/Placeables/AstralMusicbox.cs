using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class AstralMusicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Astral Biome)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.AstralMusicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = 4;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
