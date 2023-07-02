using Terraria;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;

        public const string CalamityWikiURL = "https://calamitymod.wiki.gg/wiki/{}";

        internal Mod wikithis = null;
        internal Mod calamity = null;
        internal Mod bossChecklist = null;

        public CalamityModMusic() => Instance = this;

        public override void Load()
        {
            wikithis = null;
            calamity = null;
            bossChecklist = null;
            ModLoader.TryGetMod("Wikithis", out wikithis);
            ModLoader.TryGetMod("CalamityMod", out calamity);
            ModLoader.TryGetMod("BossChecklist", out bossChecklist);

            if (!Main.dedServ)
            {
                if (wikithis is not null)
                    wikithis.Call("AddModURL", this, CalamityWikiURL);
            }

        }

        public override void Unload()
        {
            wikithis = null;
            calamity = null;
            bossChecklist = null;
            Instance = null;
        }
    }
}
