using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityModMusic
{
    [Label("Configs")]
    class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => CalamityModMusic.CalamityMusicConfig = this;

        [Header("Music Changes")]

        [DefaultValue(true)]
        [Label("Title Screen - Toggling this requires a reload to take effect")]
        [Tooltip("Toggles the overriding of the title screen music to be 'The Tale of a Cruel World'")]
        public bool TitleScreenMusicEnabled {   get; set;   }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
        {
            return true;
        }
    }
}
