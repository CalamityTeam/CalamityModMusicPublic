using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AdultEidolonWyrmMusicbox", "AdultEidolonWyrmMusicBox")]
    public class PrimordialWyrmMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PrimordialWyrmMusicBox>();

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
