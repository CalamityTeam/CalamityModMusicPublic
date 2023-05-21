using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("Yharon1Musicbox")]
    public class YharonLegacyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.YharonLegacyMusicBox>();

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
						AddIngredient(calamity.Find<ModItem>("YharonSoulFragment").Type, 3).
						AddTile(calamity.Find<ModTile>("CosmicAnvil").Type).
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
