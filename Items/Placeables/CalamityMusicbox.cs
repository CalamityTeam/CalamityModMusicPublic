using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class CalamityMusicbox : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
            DisplayName.SetDefault("Music Box (The Tale of a Cruel World)");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.CalamityMusicbox>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 100000;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            Mod calamity = CalamityModMusic.Instance.calamity;
			if (calamity != null)
			{
				CreateRecipe().
					AddIngredient(ItemID.MusicBox).
					AddIngredient(calamity.Find<ModItem>("BrimstoneSlag").Type, 12).
					AddIngredient(calamity.Find<ModItem>("EssenceofChaos").Type, 3).
					AddTile(calamity.Find<ModTile>("AshenAltar").Type).
					Register();
			}
        }
    }
}
