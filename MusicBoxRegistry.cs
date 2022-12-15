using CalamityModMusic.Items.Placeables;
using CalamityModMusic.Tiles;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;
using AbyssLowerMusicbox = CalamityModMusic.Items.Placeables.AbyssLowerMusicbox;
using AdultEidolonWyrmMusicbox = CalamityModMusic.Items.Placeables.AdultEidolonWyrmMusicbox;
using AquaticScourgeMusicbox = CalamityModMusic.Items.Placeables.AquaticScourgeMusicbox;
using AstrageldonMusicbox = CalamityModMusic.Items.Placeables.AstrageldonMusicbox;
using AstralMusicbox = CalamityModMusic.Items.Placeables.AstralMusicbox;
using AstrumDeusMusicbox = CalamityModMusic.Items.Placeables.AstrumDeusMusicbox;
using BioLabMusicbox = CalamityModMusic.Items.Placeables.BioLabMusicbox;
using BossRush1Musicbox = CalamityModMusic.Items.Placeables.BossRushTier1MusicboxItem;
using BossRush2Musicbox = CalamityModMusic.Items.Placeables.BossRushTier2MusicboxItem;
using BossRush3Musicbox = CalamityModMusic.Items.Placeables.BossRushTier3MusicboxItem;
// using BossRush4Musicbox = CalamityModMusic.Items.Placeables.BossRushTier4MusicboxItem;
// using BossRush5Musicbox = CalamityModMusic.Items.Placeables.BossRushTier5MusicboxItem;
using BrimmyMusicbox = CalamityModMusic.Items.Placeables.BrimmyMusicbox;
using BumblebirbMusicbox = CalamityModMusic.Items.Placeables.BumblebirbMusicbox;
using CalamitasMusicbox = CalamityModMusic.Items.Placeables.CalamitasMusicbox;
using CalamityMusicbox = CalamityModMusic.Items.Placeables.CalamityMusicbox;
using CeaselessVoidMusicbox = CalamityModMusic.Items.Placeables.CeaselessVoidMusicbox;
using CrabulonMusicbox = CalamityModMusic.Items.Placeables.CrabulonMusicbox;
using CragMusicbox = CalamityModMusic.Items.Placeables.CragMusicbox;
using CryogenMusicbox = CalamityModMusic.Items.Placeables.CryogenMusicbox;
using DesertScourgeMusicbox = CalamityModMusic.Items.Placeables.DesertScourgeMusicbox;
using DoGMusicbox = CalamityModMusic.Items.Placeables.DoGMusicbox;
using DoGP2Musicbox = CalamityModMusic.Items.Placeables.DoGP2Musicbox;
using ExoMechsMusicbox = CalamityModMusic.Items.Placeables.ExoMechsMusicboxItem;
using HigherAbyssMusicbox = CalamityModMusic.Items.Placeables.HigherAbyssMusicbox;
using HiveMindMusicbox = CalamityModMusic.Items.Placeables.HiveMindMusicbox;
using LeviathanMusicbox = CalamityModMusic.Items.Placeables.LeviathanMusicbox;
using PerforatorMusicbox = CalamityModMusic.Items.Placeables.PerforatorMusicbox;
using PlaguebringerMusicbox = CalamityModMusic.Items.Placeables.PlaguebringerMusicbox;
using PolterghastMusicbox = CalamityModMusic.Items.Placeables.PolterghastMusicbox;
using ProfanedGuardianMusicbox = CalamityModMusic.Items.Placeables.ProfanedGuardianMusicbox;
using ProvidenceMusicbox = CalamityModMusic.Items.Placeables.ProvidenceMusicbox;
using RavagerMusicbox = CalamityModMusic.Items.Placeables.RavagerMusicbox;
using SCalAMusicbox = CalamityModMusic.Items.Placeables.SCalAMusicbox;
using SCalEMusicbox = CalamityModMusic.Items.Placeables.SCalEMusicbox;
using SCalGMusicbox = CalamityModMusic.Items.Placeables.SCalGMusicbox;
using SCalLMusicbox = CalamityModMusic.Items.Placeables.SCalLMusicbox;
using SignusMusicbox = CalamityModMusic.Items.Placeables.SignusMusicbox;
using SirenIdleMusicbox = CalamityModMusic.Items.Placeables.SirenIdleMusicbox;
using SirenMusicbox = CalamityModMusic.Items.Placeables.SirenMusicbox;
using SlimeGodMusicbox = CalamityModMusic.Items.Placeables.SlimeGodMusicbox;
using StormWeaverMusicbox = CalamityModMusic.Items.Placeables.StormWeaverMusicbox;
using SulphurousMusicbox = CalamityModMusic.Items.Placeables.SulphurousMusicbox;
using SulphurousSeaNightMusicbox = CalamityModMusic.Items.Placeables.SulphurousSeaNightMusicbox;
using SunkenSeaMusicbox = CalamityModMusic.Items.Placeables.SunkenSeaMusicbox;
using VoidMusicbox = CalamityModMusic.Items.Placeables.VoidMusicbox;
using Yharon1Musicbox = CalamityModMusic.Items.Placeables.Yharon1Musicbox;
using Yharon2Musicbox = CalamityModMusic.Items.Placeables.Yharon2Musicbox;
using Yharon3Musicbox = CalamityModMusic.Items.Placeables.Yharon3Musicbox;

namespace CalamityModMusic
{
    public class MusicBoxRegistry : ModSystem
    {
        private static void AddMusicBox(string musicFile, int itemID, int tileID)
        {
            Mod musicMod = CalamityModMusic.Instance;
            int musicID = MusicLoader.GetMusicSlot(musicMod, musicFile);
            MusicLoader.AddMusicBox(musicMod, musicID, itemID, tileID);
        }

        public override void PostSetupContent()
        {
            if (!Main.dedServ)
            {
                // Boss Music - Alphabetised.
                AddMusicBox("Sounds/Music/AdultEidolonWyrm", ModContent.ItemType<AdultEidolonWyrmMusicbox>(), ModContent.TileType<Tiles.AdultEidolonWyrmMusicbox>());
                AddMusicBox("Sounds/Music/Anahita", ModContent.ItemType<SirenMusicbox>(), ModContent.TileType<Tiles.SirenMusicbox>());
                AddMusicBox("Sounds/Music/AnahitaPreboss", ModContent.ItemType<SirenIdleMusicbox>(), ModContent.TileType<Tiles.SirenIdleMusicbox>());
                AddMusicBox("Sounds/Music/AquaticScourge", ModContent.ItemType<AquaticScourgeMusicbox>(), ModContent.TileType<Tiles.AquaticScourgeMusicbox>());
                AddMusicBox("Sounds/Music/AstrumAureus", ModContent.ItemType<AstrageldonMusicbox>(), ModContent.TileType<Tiles.AstrageldonMusicbox>());
                AddMusicBox("Sounds/Music/AstrumDeus", ModContent.ItemType<AstrumDeusMusicbox>(), ModContent.TileType<Tiles.AstrumDeusMusicbox>());
                AddMusicBox("Sounds/Music/BrimstoneElemental", ModContent.ItemType<BrimmyMusicbox>(), ModContent.TileType<Tiles.BrimmyMusicbox>());
                AddMusicBox("Sounds/Music/Calamitas", ModContent.ItemType<CalamitasMusicbox>(), ModContent.TileType<Tiles.CalamitasMusicbox>());
                AddMusicBox("Sounds/Music/CeaselessVoid", ModContent.ItemType<CeaselessVoidMusicbox>(), ModContent.TileType<Tiles.CeaselessVoidMusicbox>());
                AddMusicBox("Sounds/Music/Crabulon", ModContent.ItemType<CrabulonMusicbox>(), ModContent.TileType<Tiles.CrabulonMusicbox>());
                AddMusicBox("Sounds/Music/Cryogen", ModContent.ItemType<CryogenMusicbox>(), ModContent.TileType<Tiles.CryogenMusicbox>());
                AddMusicBox("Sounds/Music/DesertScourge", ModContent.ItemType<DesertScourgeMusicbox>(), ModContent.TileType<Tiles.DesertScourgeMusicbox>());
                AddMusicBox("Sounds/Music/DevourerOfGodsP1", ModContent.ItemType<DoGMusicbox>(), ModContent.TileType<Tiles.DoGMusicbox>());
                AddMusicBox("Sounds/Music/DevourerOfGodsP2", ModContent.ItemType<DoGP2Musicbox>(), ModContent.TileType<Tiles.DoGP2Musicbox>());
                AddMusicBox("Sounds/Music/Dragonfolly", ModContent.ItemType<BumblebirbMusicbox>(), ModContent.TileType<Tiles.BumblebirbMusicbox>());
                AddMusicBox("Sounds/Music/ExoMechs", ModContent.ItemType<ExoMechsMusicbox>(), ModContent.TileType<Tiles.ExoMechsMusicbox>());
                AddMusicBox("Sounds/Music/HiveMind", ModContent.ItemType<HiveMindMusicbox>(), ModContent.TileType<Tiles.HiveMindMusicbox>());
                AddMusicBox("Sounds/Music/LeviathanAndAnahita", ModContent.ItemType<LeviathanMusicbox>(), ModContent.TileType<Tiles.LeviathanMusicbox>());
                AddMusicBox("Sounds/Music/BoomerDuke", ModContent.ItemType<BoomerDukeMusicbox>(), ModContent.TileType<Tiles.BoomerDukeMusicboxTile>());
                AddMusicBox("Sounds/Music/Perforators", ModContent.ItemType<PerforatorMusicbox>(), ModContent.TileType<Tiles.PerforatorMusicbox>());
                AddMusicBox("Sounds/Music/PlaguebringerGoliath", ModContent.ItemType<PlaguebringerMusicbox>(), ModContent.TileType<Tiles.PlaguebringerMusicbox>());
                AddMusicBox("Sounds/Music/Polterghast", ModContent.ItemType<PolterghastMusicbox>(), ModContent.TileType<Tiles.PolterghastMusicbox>());
                AddMusicBox("Sounds/Music/Guardians", ModContent.ItemType<ProfanedGuardianMusicbox>(), ModContent.TileType<Tiles.ProfanedGuardianMusicbox>());
                AddMusicBox("Sounds/Music/Providence", ModContent.ItemType<ProvidenceMusicbox>(), ModContent.TileType<Tiles.ProvidenceMusicbox>()); //Seamless
                AddMusicBox("Sounds/Music/Ravager", ModContent.ItemType<RavagerMusicbox>(), ModContent.TileType<Tiles.RavagerMusicbox>());
                AddMusicBox("Sounds/Music/SupremeCalamitas1", ModContent.ItemType<SCalGMusicbox>(), ModContent.TileType<Tiles.SCalGMusicbox>());
                AddMusicBox("Sounds/Music/SupremeCalamitas2", ModContent.ItemType<SCalLMusicbox>(), ModContent.TileType<Tiles.SCalLMusicbox>());
                AddMusicBox("Sounds/Music/SupremeCalamitas3", ModContent.ItemType<SCalEMusicbox>(), ModContent.TileType<Tiles.SCalEMusicbox>());
                AddMusicBox("Sounds/Music/SupremeCalamitas4", ModContent.ItemType<SCalAMusicbox>(), ModContent.TileType<Tiles.SCalAMusicbox>());
                AddMusicBox("Sounds/Music/Signus", ModContent.ItemType<SignusMusicbox>(), ModContent.TileType<Tiles.SignusMusicbox>());
                AddMusicBox("Sounds/Music/SlimeGod", ModContent.ItemType<SlimeGodMusicbox>(), ModContent.TileType<Tiles.SlimeGodMusicbox>());
                AddMusicBox("Sounds/Music/Weaver", ModContent.ItemType<StormWeaverMusicbox>(), ModContent.TileType<Tiles.StormWeaverMusicbox>());
                AddMusicBox("Sounds/Music/YharonLegacy", ModContent.ItemType<Yharon1Musicbox>(), ModContent.TileType<Tiles.Yharon1Musicbox>());
                AddMusicBox("Sounds/Music/YharonP1", ModContent.ItemType<Yharon2Musicbox>(), ModContent.TileType<Tiles.Yharon2Musicbox>());
                AddMusicBox("Sounds/Music/YharonP2", ModContent.ItemType<Yharon3Musicbox>(), ModContent.TileType<Tiles.Yharon3Musicbox>());

                // Biome Music.
                AddMusicBox("Sounds/Music/Abyss1", ModContent.ItemType<HigherAbyssMusicbox>(), ModContent.TileType<Tiles.HigherAbyssMusicbox>());
                AddMusicBox("Sounds/Music/Abyss2", ModContent.ItemType<AbyssLowerMusicbox>(), ModContent.TileType<Tiles.AbyssLowerMusicbox>());
                AddMusicBox("Sounds/Music/Abyss3", ModContent.ItemType<VoidMusicbox>(), ModContent.TileType<Tiles.VoidMusicbox>());
                AddMusicBox("Sounds/Music/Astral", ModContent.ItemType<AstralMusicbox>(), ModContent.TileType<Tiles.AstralMusicbox>()); //Seamless
                AddMusicBox("Sounds/Music/AstralUnderground", ModContent.ItemType<AstralUndergroundMusicbox>(), ModContent.TileType<Tiles.AstralUndergroundMusicboxTile>()); //Seamless
                AddMusicBox("Sounds/Music/BioLab", ModContent.ItemType<BioLabMusicbox>(), ModContent.TileType<Tiles.BioLabMusicbox>());
                AddMusicBox("Sounds/Music/Crag", ModContent.ItemType<CragMusicbox>(), ModContent.TileType<Tiles.CragMusicbox>());
                AddMusicBox("Sounds/Music/Calamity", ModContent.ItemType<CalamityMusicbox>(), ModContent.TileType<Tiles.CalamityMusicbox>()); //Seamless
                AddMusicBox("Sounds/Music/SulphurousSeaDay", ModContent.ItemType<SulphurousMusicbox>(), ModContent.TileType<Tiles.SulphurousMusicbox>());
                AddMusicBox("Sounds/Music/SulphurousSeaNight", ModContent.ItemType<SulphurousSeaNightMusicbox>(), ModContent.TileType<Tiles.SulphurousSeaNightMusicbox>());
                AddMusicBox("Sounds/Music/SunkenSea", ModContent.ItemType<SunkenSeaMusicbox>(), ModContent.TileType<Tiles.SunkenSeaMusicbox>());

                // Event Music.
                AddMusicBox("Sounds/Music/AcidRain1", ModContent.ItemType<AcidRain1Musicbox>(), ModContent.TileType<AcidRain1MusicboxTile>()); //Seamless
                AddMusicBox("Sounds/Music/AcidRain2", ModContent.ItemType<AcidRain2Musicbox>(), ModContent.TileType<AcidRain2MusicboxTile>());
                AddMusicBox("Sounds/Music/BossRushTier1", ModContent.ItemType<BossRush1Musicbox>(), ModContent.TileType<BossRushTier1Musicbox>());
                AddMusicBox("Sounds/Music/BossRushTier2", ModContent.ItemType<BossRush2Musicbox>(), ModContent.TileType<BossRushTier2Musicbox>());
                AddMusicBox("Sounds/Music/BossRushTier3", ModContent.ItemType<BossRush3Musicbox>(), ModContent.TileType<BossRushTier3Musicbox>());
                //AddMusicBox("Sounds/Music/BossRushTier4", ModContent.ItemType<BossRush4Musicbox>(), ModContent.TileType<BossRushTier4Musicbox>());
                //AddMusicBox("Sounds/Music/BossRushTier5", ModContent.ItemType<BossRush5Musicbox>(), ModContent.TileType<BossRushTier5Musicbox>());
            }
        }
    }
}
