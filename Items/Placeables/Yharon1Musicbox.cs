using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Yharon1Musicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Infernal Catharsis)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = 1;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Yharon1Musicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = 4;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
        }
    }
}
