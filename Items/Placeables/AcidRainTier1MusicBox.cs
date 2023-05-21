using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AcidRain1Musicbox")]
    public class AcidRainTier1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AcidRainTier1MusicBox>();
    
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
