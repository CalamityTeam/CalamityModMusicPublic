using CalamityModMusic.Items.Placeables;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class ExternalModSupport : ModSystem
    {
        public override void PostSetupContent()
        {
            BossChecklistSetup();
            MusicDisplaySetup();
        }

        private void BossChecklistSetup()
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

        private void MusicDisplaySetup()
        {
            Mod musicDisplay = CalamityModMusic.Instance.musicDisplay;
            if (musicDisplay is null)
                return;

            void AddMusic(string name, string author, string file)
            {
                short slot = (short)MusicLoader.GetMusicSlot(Mod, $"Sounds/Music/{file}");
                musicDisplay.Call("AddMusic", slot, name, "by " + author, "Calamity Mod Music");
            }

            AddMusic("Hadopelagic Pressure", "DM DOKURO", "AbyssLayer2");
            AddMusic("R'LYEH", "RoverdriveX", "AbyssLayer3");
            AddMusic("void", "DM DOKURO", "AbyssLayer4");
            AddMusic("corrosion!", "RoverdriveX", "AcidRainTier1");
            AddMusic("nuclear monsoon", "PinpinNeon", "AcidRainTier3");
            AddMusic("Threats of the Ocean Floor", "DM DOKURO", "AdultEidolonWyrm");
            AddMusic("Siren's War Cry", "DM DOKURO", "Anahita");
            AddMusic("Siren's Call", "DM DOKURO", "AnahitasLure");
            AddMusic("Outcast of the Sulphurous Seas", "DM DOKURO", "AquaticScourge");
            AddMusic("The Heaven-Sent Abomination", "DM DOKURO", "AstralInfection");
            AddMusic("Treasures Within the Abomination", "DM DOKURO", "AstralInfectionUnderground");
            AddMusic("Interstellar Stomper", "DM DOKURO", "AstrumAureus");
            AddMusic("Pest of the Cosmos", "DM DOKURO", "AstrumDeus");
            AddMusic("Engineer's Sanctum", "Heart Plus Up!", "BioLab");
            AddMusic("Ensemble of Fools", "CDMusic", "BossRushTier1");
            AddMusic("Onslaught of Beasts", "CDMusic", "BossRushTier2");
            AddMusic("Reign of Lords", "CDMusic", "BossRushTier3");
            AddMusic("The Step Below Hell", "DM DOKURO", "BrimstoneCrags");
            AddMusic("Left Alone", "DM DOKURO", "BrimstoneElemental");
            AddMusic("Raw, Unfiltered Calamity", "DM DOKURO", "CalamitasClone");
            AddMusic("Stained, Brutal Calamity (Acceptance)", "DM DOKURO", "CalamitasDefeat");
            AddMusic("Stained, Brutal Calamity (Grief)", "DM DOKURO", "CalamitasPhase1");
            AddMusic("Stained, Brutal Calamity (Lament)", "DM DOKURO", "CalamitasPhase2");
            AddMusic("Stained, Brutal Calamity (Epiphany)", "DM DOKURO", "CalamitasPhase3");
            AddMusic("The Tale of a Cruel World", "DM DOKURO", "CalamityTitle");
            AddMusic("Servants of the Scourge (Type V)", "DM DOKURO", "CeaselessVoid");
            AddMusic("Infestation", "DM DOKURO", "Crabulon");
            AddMusic("Antarctic Reinforcement", "DM DOKURO", "Cryogen");
            AddMusic("Guardian of the Former Seas", "DM DOKURO", "DesertScourge");
            AddMusic("Scourge of the Universe", "DM DOKURO", "DevourerofGodsPhase1");
            AddMusic("Universal Collapse", "DM DOKURO", "DevourerofGodsPhase2");
            AddMusic("Murderswarm", "DM DOKURO", "Dragonfolly");
            AddMusic("Inferior Fabrications", "PinpinNeon", "ExoMechs");
            AddMusic("The Filthy Mind", "DM DOKURO and SixteenInMono", "HiveMind");
            AddMusic("Forbidden Lullaby", "DM DOKURO", "Leviathan");
            AddMusic("Toxic Wisdom", "DM DOKURO", "OldDuke");
            AddMusic("Blood Coagulant", "DM DOKURO and SixteenInMono", "Perforators");
            AddMusic("Fly of Beelzebub", "DM DOKURO", "PlaguebringerGoliath");
            AddMusic("Feral Amalgamation", "DM DOKURO", "Polterghast");
            AddMusic("Unholy Ambush", "DM DOKURO", "ProfanedGuardians");
            AddMusic("Unholy Insurgency", "DM DOKURO", "Providence");
            AddMusic("Open Frenzy", "DM DOKURO", "Ravager");
            AddMusic("Servants of the Scourge (Type S)", "DM DOKURO", "Signus");
            AddMusic("Return to Slime", "DM DOKURO and SixteenInMono", "SlimeGod");
            AddMusic("Servants of the Scourge (Type W)", "DM DOKURO", "StormWeaver");
            AddMusic("wasteland", "DM DOKURO", "SulphurousSeaDay");
            AddMusic("caustic tides", "Heart Plus Up!", "SulphurousSeaNight");
            AddMusic("sanctuary", "DM DOKURO", "SunkenSea");
            AddMusic("Infernal Catharsis", "DM DOKURO", "YharonLegacy");
            AddMusic("Infernal Catharsis (Rebirth)", "DM DOKURO", "YharonPhase1");
            AddMusic("Roar of the Jungle Dragon", "DM DOKURO", "YharonPhase2");
        }
    }
}
