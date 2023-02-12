using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AdultEidolonWyrmMusicbox")]
    public class AdultEidolonWyrmMusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Adult Eidolon Wyrm)");
            Tooltip.SetDefault("Plays 'Threats of the Ocean Floor' by DM DOKURO");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.AdultEidolonWyrmMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }
        public override void AddRecipes()
        {
            Mod calamity = CalamityModMusic.Instance.calamity;
            if (calamity != null)
            {
                // If any of these Cal items don't exist or got renamed, don't make a recipe at all
                try
                {
                    CreateRecipe().
                        AddIngredient(ItemID.MusicBox).
                        AddIngredient(calamity.Find<ModItem>("Voidstone").Type, 50).
                        AddIngredient(calamity.Find<ModItem>("Lumenyl").Type, 15).
                        AddIngredient(calamity.Find<ModItem>("RuinousSoul").Type, 3).
                        AddTile(TileID.LunarCraftingStation).
                        Register();
                }
                catch
                {
                    CalamityModMusic.Instance.Logger.Debug("One of the items or tiles in this recipe got renamed internally. Please report this in the #bugs-read-pins channel of the official Calamity discord server.");
                }
            }
        }
    }
}
