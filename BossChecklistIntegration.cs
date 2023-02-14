using CalamityModMusic.Items.Placeables;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class BossChecklistIntegration : ModSystem
    {
        public override void PostSetupContent()
        {
            Mod calamity = CalamityModMusic.Instance.calamity;
            Mod bossChecklist = CalamityModMusic.Instance.bossChecklist;

            if (calamity != null && bossChecklist != null)
            {
                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Desert Scourge",
                ModContent.ItemType<DesertScourgeMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Giant Clam",
                ModContent.ItemType<SunkenSeaMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Crabulon",
                ModContent.ItemType<CrabulonMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod The Hive Mind",
                ModContent.ItemType<HiveMindMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod The Perforators",
                ModContent.ItemType<PerforatorsMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Slime God",
                ModContent.ItemType<SlimeGodMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Cryogen",
                ModContent.ItemType<CryogenMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Aquatic Scourge",
                ModContent.ItemType<AquaticScourgeMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Brimstone Elemental",
                ModContent.ItemType<BrimstoneElementalMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod The Calamitas Clone",
                ModContent.ItemType<CalamitasCloneMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Leviathan",
                new List<int>() { ModContent.ItemType<LeviathanMusicBox>(), ModContent.ItemType<AnahitaMusicBox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Astrum Aureus",
                ModContent.ItemType<AstrumAureusMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Plaguebringer Goliath",
                ModContent.ItemType<PlaguebringerGoliathMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Ravager",
                ModContent.ItemType<RavagerMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Astrum Deus",
                ModContent.ItemType<AstrumDeusMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Profaned Guardians",
                ModContent.ItemType<ProfanedGuardiansMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Dragonfolly",
                ModContent.ItemType<DragonfollyMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Providence",
                ModContent.ItemType<ProvidenceMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Ceaseless Void",
                ModContent.ItemType<CeaselessVoidMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Storm Weaver",
                ModContent.ItemType<StormWeaverMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Signus",
                ModContent.ItemType<SignusMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Polterghast",
                ModContent.ItemType<PolterghastMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Old Duke",
                ModContent.ItemType<OldDukeMusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Devourer of Gods",
                new List<int>() { ModContent.ItemType<DevourerofGodsPhase1MusicBox>(), ModContent.ItemType<DevourerofGodsPhase2MusicBox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Yharon",
                new List<int>() { ModContent.ItemType<YharonPhase1MusicBox>(), ModContent.ItemType<YharonPhase2MusicBox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Exo Mechs",
                new List<int>() { ModContent.ItemType<ExoMechsMusicBox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Supreme Witch, Calamitas",
                new List<int>() { ModContent.ItemType<CalamitasPhase1MusicBox>(), ModContent.ItemType<CalamitasPhase2MusicBox>(), ModContent.ItemType<CalamitasPhase3MusicBox>(), ModContent.ItemType<CalamitasDefeatMusicBox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain",
                ModContent.ItemType<AcidRainTier1MusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain (Post-AS)",
                //ModContent.ItemType<AcidRainTier2MusicBox>());
                ModContent.ItemType<AcidRainTier1MusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain (Post-Polter)",
                ModContent.ItemType<AcidRainTier3MusicBox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Boss Rush",
                new List<int>() { ModContent.ItemType<BossRushTier1MusicBox>(), ModContent.ItemType<BossRushTier2MusicBox>(), ModContent.ItemType<BossRushTier3MusicBox>()/*, ModContent.ItemType<BossRushTier4MusicBox>()*//*, ModContent.ItemType<BossRushTier5MusicBox>() */});
            }
        }
    }
}
