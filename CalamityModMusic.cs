using Terraria;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;

        public const string CalamityWikiURL = "calamitymod.wiki.gg";

        internal Mod wikithis = null;

        public CalamityModMusic() => Instance = this;

        public override void Load()
        {
            wikithis = null;
            ModLoader.TryGetMod("Wikithis", out wikithis);

            if (!Main.dedServ)
            {
                if (wikithis is not null)
                    wikithis.Call("AddModURL", this, CalamityWikiURL);
            }

        }

        public override void Unload()
        {
            wikithis = null;
            Instance = null;
        }
    }
}
