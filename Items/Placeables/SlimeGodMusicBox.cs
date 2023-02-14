using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SlimeGodMusicbox")]
    public class SlimeGodMusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Slime God)");
            Tooltip.SetDefault("Plays 'Return to Slime' by DM DOKURO and SixteenInMono");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.SlimeGodMusicBox>();
            Item.width = 32;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}