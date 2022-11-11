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
                ModContent.ItemType<DesertScourgeMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Giant Clam",
                ModContent.ItemType<SunkenSeaMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Crabulon",
                ModContent.ItemType<CrabulonMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Hive Mind",
                ModContent.ItemType<HiveMindMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod The Perforators",
                ModContent.ItemType<PerforatorMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Slime God",
                ModContent.ItemType<SlimeGodMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Cryogen",
                ModContent.ItemType<CryogenMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Aquatic Scourge",
                ModContent.ItemType<AquaticScourgeMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Brimstone Elemental",
                ModContent.ItemType<BrimmyMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod The Calamitas Clone",
                ModContent.ItemType<CalamitasMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Leviathan",
                new List<int>() { ModContent.ItemType<LeviathanMusicbox>(), ModContent.ItemType<SirenMusicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Astrum Aureus",
                ModContent.ItemType<AstrageldonMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Plaguebringer Goliath",
                ModContent.ItemType<PlaguebringerMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Ravager",
                ModContent.ItemType<RavagerMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Astrum Deus",
                ModContent.ItemType<AstrumDeusMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Profaned Guardians",
                ModContent.ItemType<ProfanedGuardianMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Dragonfolly",
                ModContent.ItemType<BumblebirbMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Providence",
                ModContent.ItemType<ProvidenceMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Ceaseless Void",
                ModContent.ItemType<CeaselessVoidMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Storm Weaver",
                ModContent.ItemType<StormWeaverMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Signus",
                ModContent.ItemType<SignusMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Polterghast",
                ModContent.ItemType<PolterghastMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Old Duke",
                ModContent.ItemType<BoomerDukeMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Devourer of Gods",
                new List<int>() { ModContent.ItemType<DoGMusicbox>(), ModContent.ItemType<DoGP2Musicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Yharon",
                new List<int>() { ModContent.ItemType<Yharon2Musicbox>(), ModContent.ItemType<Yharon3Musicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Exo Mechs",
                new List<int>() { ModContent.ItemType<ExoMechsMusicboxItem>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Supreme Calamitas",
                new List<int>() { ModContent.ItemType<SCalGMusicbox>(), ModContent.ItemType<SCalLMusicbox>(), ModContent.ItemType<SCalEMusicbox>(), ModContent.ItemType<SCalAMusicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain",
                ModContent.ItemType<AcidRain1Musicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain (Post-AS)",
                ModContent.ItemType<AcidRain1Musicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                "CalamityMod Acid Rain (Post-Polter)",
                ModContent.ItemType<AcidRain2Musicbox>());
            }
        }
    }
}
