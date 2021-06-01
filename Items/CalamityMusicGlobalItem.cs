using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace CalamityModMusic.Items
{
    class CalamityMusicGlobalItem : GlobalItem
    {
        public override bool? PrefixChance(Item item, int pre, UnifiedRandom rand)
        {
            if (item.modItem != null && item.modItem.mod == CalamityModMusic.Instance)
            {
                return false;
            }
            return null;
        }
    }
}
