using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AbyssLowerMusicbox")]
    public class AbyssLayer3MusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Abyss - Layer 3)");
            Tooltip.SetDefault("Plays 'R'LYEH' by RoverdriveX");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.AbyssLayer3MusicBox>();
            Item.width = 32;
            Item.height = 28;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}
