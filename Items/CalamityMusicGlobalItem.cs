using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace CalamityModMusic.Items
{
    public class CalamityMusicGlobalItem : GlobalItem
    {
        // No items from this mod are capable of receiving reforges.
        public override bool? PrefixChance(Item item, int pre, UnifiedRandom rand) =>
            item.modItem != null && item.modItem.mod == CalamityModMusic.Instance ? false : (bool?)null;
    }
}
