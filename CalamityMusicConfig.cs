using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityModMusic
{
    [Label("Config")]
    [BackgroundColor(49, 32, 36, 216)]
    public class CalamityMusicConfig : ModConfig
    {
        public static CalamityMusicConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Music Changes")]

        [Label("Replace Title Music")]
        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(true)]
        [ReloadRequired]
        [Tooltip("Replaces the vanilla Terraria title screen music with 'The Tale of a Cruel World'.\nThis option does nothing if Terraria Overhaul is enabled.\nThis option requires a reload to take effect.")]
        public bool ReplaceTitleMusic { get; set; }

        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message) => true;
    }
}
