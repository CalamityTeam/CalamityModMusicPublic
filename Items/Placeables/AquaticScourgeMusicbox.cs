using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class AquaticScourgeMusicbox: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Aquatic Scourge)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.AquaticScourgeMusicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = 4;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
