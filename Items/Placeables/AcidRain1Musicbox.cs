using Terraria.ModLoader;
using Terraria.ID;
using CalamityModMusic.Tiles;

namespace CalamityModMusic.Items.Placeables
{
    public class AcidRain1Musicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Acidic Downpour)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<AcidRain1MusicboxTile>();
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            Mod calamity = ModLoader.GetMod("CalamityMod");
            if (calamity != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(calamity.GetItem("RuinousSoul"));
                recipe.AddIngredient(calamity.GetItem("Acidwood"), 10);
                recipe.AddIngredient(calamity.GetItem("CorrodedFossil"), 10); 
                recipe.AddIngredient(calamity.GetItem("SulfuricScale"), 10);
                recipe.AddIngredient(ItemID.MusicBox);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}