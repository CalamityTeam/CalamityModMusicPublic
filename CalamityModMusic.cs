using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;
        public CalamityModMusic() => Instance = this;
        public override void Unload() => Instance = null;
    }
}
