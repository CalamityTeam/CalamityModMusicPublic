using CalamityModMusic.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AcidRain1Musicbox")]
    public class AcidRainTier1MusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (Acid Rain - Tier 1)");
            Tooltip.SetDefault("Plays 'corrosion!' by RoverdriveX");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.AcidRainTier1MusicBox>();
            Item.width = 32;
            Item.height = 18;
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
						AddIngredient(calamity.Find<ModItem>("Acidwood").Type, 10).
						AddIngredient(calamity.Find<ModItem>("SulphuricScale").Type, 10).
						AddIngredient(calamity.Find<ModItem>("CorrodedFossil").Type, 10).
						AddIngredient(calamity.Find<ModItem>("RuinousSoul").Type).
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
