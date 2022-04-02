using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class ExoMechsMusicboxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Exo Mechs)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.ExoMechsMusicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
