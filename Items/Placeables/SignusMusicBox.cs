using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SignusMusicbox")]
    public class SignusMusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Signus)");
            Tooltip.SetDefault("Plays 'Servants of the Scourge (Type S)' by DM DOKURO");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.SignusMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
