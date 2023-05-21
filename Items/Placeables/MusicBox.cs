using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    public abstract class MusicBox : ModItem
    {
        public abstract int MusicBoxTile { get; }
        public virtual bool Obtainable { get; } = true;

        public override void SetStaticDefaults()
        {
            ItemID.Sets.CanGetPrefixes[Type] = false;
            ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.MusicBox;

            if (!Obtainable)
            {
                Item.ResearchUnlockCount = 0;
            }
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(MusicBoxTile, 0);
        }
    }
}
