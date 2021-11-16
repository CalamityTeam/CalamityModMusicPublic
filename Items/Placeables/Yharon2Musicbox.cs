using Terraria.ModLoader;
using CalamityModMusic.Tiles;

namespace CalamityModMusic.Items.Placeables
{
    public class Yharon2Musicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Yharon, Rebirth)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.Yharon2Musicbox>();
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }

		public override void AddRecipes()
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			if (calamityMod != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(calamityMod.ItemType("DarksunFragment"), 5);
				recipe.AddIngredient(calamityMod.ItemType("CosmiliteBar"), 3);
				recipe.SetResult(this);
				recipe.AddTile(calamityMod.TileType("CosmicAnvil"));
				recipe.AddRecipe();
			}
		}
    }
}