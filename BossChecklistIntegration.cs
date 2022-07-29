using CalamityModMusic.Items.Placeables;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class BossChecklistIntegration : ModSystem
    {
        public override void PostSetupContent()
        {
            bool calamityExists = ModLoader.TryGetMod("CalamityMod", out var calamity);
            bool bossChecklistExists = ModLoader.TryGetMod("BossChecklist", out var bossChecklist);

            if (calamityExists && bossChecklistExists)
            {
                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Desert Scourge",
                ModContent.ItemType<DesertScourgeMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Giant Clam",
                ModContent.ItemType<SunkenSeaMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Crabulon",
                ModContent.ItemType<CrabulonMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Hive Mind",
                ModContent.ItemType<HiveMindMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "The Perforators",
                ModContent.ItemType<PerforatorMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Slime God",
                ModContent.ItemType<SlimeGodMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Cryogen",
                ModContent.ItemType<CryogenMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Aquatic Scourge",
                ModContent.ItemType<AquaticScourgeMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Brimstone Elemental",
                ModContent.ItemType<BrimmyMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Calamitas",
                ModContent.ItemType<CalamitasMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Leviathan",
                new List<int>() { ModContent.ItemType<LeviathanMusicbox>(), ModContent.ItemType<SirenMusicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Astrum Aureus",
                ModContent.ItemType<AstrageldonMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Plaguebringer Goliath",
                ModContent.ItemType<PlaguebringerMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Ravager",
                ModContent.ItemType<RavagerMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Astrum Deus",
                ModContent.ItemType<AstrumDeusMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Profaned Guardians",
                ModContent.ItemType<ProfanedGuardianMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Dragonfolly",
                ModContent.ItemType<BumblebirbMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Providence",
                ModContent.ItemType<ProvidenceMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Ceaseless Void",
                ModContent.ItemType<CeaselessVoidMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Storm Weaver",
                ModContent.ItemType<StormWeaverMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Signus",
                ModContent.ItemType<SignusMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Polterghast",
                ModContent.ItemType<PolterghastMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Devourer of Gods",
                new List<int>() { ModContent.ItemType<DoGMusicbox>(), ModContent.ItemType<DoGP2Musicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Yharon",
                new List<int>() { ModContent.ItemType<Yharon2Musicbox>(), ModContent.ItemType<Yharon3Musicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Exo Mechs",
                new List<int>() { ModContent.ItemType<ExoMechsMusicboxItem>() });

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Supreme Calamitas",
                new List<int>() { ModContent.ItemType<SCalGMusicbox>(), ModContent.ItemType<SCalLMusicbox>(), ModContent.ItemType<SCalEMusicbox>(), ModContent.ItemType<SCalAMusicbox>() });

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Adult Eidolon Wyrm",
                ModContent.ItemType<AdultEidolonWyrmMusicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Acid Rain",
                ModContent.ItemType<AcidRain1Musicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Acid Rain (Post-AS)",
                ModContent.ItemType<AcidRain1Musicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Acid Rain (Post-Polter)",
                ModContent.ItemType<AcidRain2Musicbox>());

                bossChecklist.Call(
                "AddToBossCollection",
                calamity.Name,
                "Old Duke",
                ModContent.ItemType<BoomerDukeMusicbox>());
            }
        }
    }
}
