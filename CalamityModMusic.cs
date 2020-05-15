using Microsoft.Xna.Framework.Audio;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Threading;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityModMusic.Items.Placeables;
using Terraria.ModLoader.Exceptions;
using Terraria.ModLoader.Audio;
using Terraria.ModLoader.Config;
using System.Reflection;
using CalamityModMusic.Tiles;
using AbyssLowerMusicbox = CalamityModMusic.Items.Placeables.AbyssLowerMusicbox;
using AquaticScourgeMusicbox = CalamityModMusic.Items.Placeables.AquaticScourgeMusicbox;
using AstrageldonMusicbox = CalamityModMusic.Items.Placeables.AstrageldonMusicbox;
using AstralMusicbox = CalamityModMusic.Items.Placeables.AstralMusicbox;
using AstrumDeusMusicbox = CalamityModMusic.Items.Placeables.AstrumDeusMusicbox;
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
using SunkenSeaMusicbox = CalamityModMusic.Items.Placeables.SunkenSeaMusicbox;
using VoidMusicbox = CalamityModMusic.Items.Placeables.VoidMusicbox;
using Yharon1Musicbox = CalamityModMusic.Items.Placeables.Yharon1Musicbox;
using Yharon2Musicbox = CalamityModMusic.Items.Placeables.Yharon2Musicbox;
using Yharon3Musicbox = CalamityModMusic.Items.Placeables.Yharon3Musicbox;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;
		internal static Config CalamityMusicConfig;

		private volatile bool stopTitleMusic;
		private volatile bool swapTitleMusic;
		private ManualResetEvent titleMusicStopped;
		private bool needsSwap = true;
		private bool titleOverride = false;

		public CalamityModMusic()
    	{
            Instance = this;
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                //Boss Music - Alphabetised
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AquaticScourge"), ModContent.ItemType<AquaticScourgeMusicbox>(), ModContent.TileType<Tiles.AquaticScourgeMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astrageldon"), ModContent.ItemType<AstrageldonMusicbox>(), ModContent.TileType<Tiles.AstrageldonMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumDeus"), ModContent.ItemType<AstrumDeusMusicbox>(), ModContent.TileType<Tiles.AstrumDeusMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeftAlone"), ModContent.ItemType<BrimmyMusicbox>(), ModContent.TileType<Tiles.BrimmyMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Murderswarm"), ModContent.ItemType<BumblebirbMusicbox>(), ModContent.TileType<Tiles.BumblebirbMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas"), ModContent.ItemType<CalamitasMusicbox>(), ModContent.TileType<Tiles.CalamitasMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Void"), ModContent.ItemType<CeaselessVoidMusicbox>(), ModContent.TileType<Tiles.CeaselessVoidMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crabulon"), ModContent.ItemType<CrabulonMusicbox>(), ModContent.TileType<Tiles.CrabulonMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Cryogen"), ModContent.ItemType<CryogenMusicbox>(), ModContent.TileType<Tiles.CryogenMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DesertScourge"), ModContent.ItemType<DesertScourgeMusicbox>(), ModContent.TileType<Tiles.DesertScourgeMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ScourgeofTheUniverse"), ModContent.ItemType<DoGMusicbox>(), ModContent.TileType<Tiles.DoGMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UniversalCollapse"), ModContent.ItemType<DoGP2Musicbox>(), ModContent.TileType<Tiles.DoGP2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind"), ModContent.ItemType<HiveMindMusicbox>(), ModContent.TileType<Tiles.HiveMindMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren"), ModContent.ItemType<LeviathanMusicbox>(), ModContent.TileType<Tiles.LeviathanMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BoomerDuke"), ModContent.ItemType<BoomerDukeMusicbox>(), ModContent.TileType<Tiles.BoomerDukeMusicboxTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BloodCoagulant"), ModContent.ItemType<PerforatorMusicbox>(), ModContent.TileType<Tiles.PerforatorMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PlaguebringerGoliath"), ModContent.ItemType<PlaguebringerMusicbox>(), ModContent.TileType<Tiles.PlaguebringerMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RUIN"), ModContent.ItemType<PolterghastMusicbox>(), ModContent.TileType<Tiles.PolterghastMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Guardians"), ModContent.ItemType<ProfanedGuardianMusicbox>(), ModContent.TileType<Tiles.ProfanedGuardianMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ProvidenceTheme"), ModContent.ItemType<ProvidenceMusicbox>(), ModContent.TileType<Tiles.ProvidenceMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager"), ModContent.ItemType<RavagerMusicbox>(), ModContent.TileType<Tiles.RavagerMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCG"), ModContent.ItemType<SCalGMusicbox>(), ModContent.TileType<Tiles.SCalGMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCL"), ModContent.ItemType<SCalLMusicbox>(), ModContent.TileType<Tiles.SCalLMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCE"), ModContent.ItemType<SCalEMusicbox>(), ModContent.TileType<Tiles.SCalEMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCA"), ModContent.ItemType<SCalAMusicbox>(), ModContent.TileType<Tiles.SCalAMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Signus"), ModContent.ItemType<SignusMusicbox>(), ModContent.TileType<Tiles.SignusMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Siren"), ModContent.ItemType<SirenMusicbox>(), ModContent.TileType<Tiles.SirenMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SirenLure"), ModContent.ItemType<SirenIdleMusicbox>(), ModContent.TileType<Tiles.SirenIdleMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod"), ModContent.ItemType<SlimeGodMusicbox>(), ModContent.TileType<Tiles.SlimeGodMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Weaver"), ModContent.ItemType<StormWeaverMusicbox>(), ModContent.TileType<Tiles.StormWeaverMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARON"), ModContent.ItemType<Yharon1Musicbox>(), ModContent.TileType<Tiles.Yharon1Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARONREBIRTH"), ModContent.ItemType<Yharon2Musicbox>(), ModContent.TileType<Tiles.Yharon2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DragonGod"), ModContent.ItemType<Yharon3Musicbox>(), ModContent.TileType<Tiles.Yharon3Musicbox>());

				//Biome Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sulphur"), ModContent.ItemType<SulphurousMusicbox>(), ModContent.TileType<Tiles.SulphurousMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheAbyss"), ModContent.ItemType<HigherAbyssMusicbox>(), ModContent.TileType<Tiles.HigherAbyssMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheDeepAbyss"), ModContent.ItemType<AbyssLowerMusicbox>(), ModContent.TileType<Tiles.AbyssLowerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheVoid"), ModContent.ItemType<VoidMusicbox>(), ModContent.TileType<Tiles.VoidMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astral"), ModContent.ItemType<AstralMusicbox>(), ModContent.TileType<Tiles.AstralMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstralUnderground"), ModContent.ItemType<AstralUndergroundMusicbox>(), ModContent.TileType<Tiles.AstralUndergroundMusicboxTile>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity"), ModContent.ItemType<CalamityMusicbox>(), ModContent.TileType<Tiles.CalamityMusicbox>()); //Seamless
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crag"), ModContent.ItemType<CragMusicbox>(), ModContent.TileType<Tiles.CragMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea"), ModContent.ItemType<SunkenSeaMusicbox>(), ModContent.TileType<Tiles.SunkenSeaMusicbox>());

				//Event Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AcidRain1"), ModContent.ItemType<AcidRain1Musicbox>(), ModContent.TileType<AcidRain1MusicboxTile>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AcidRain2"), ModContent.ItemType<AcidRain2Musicbox>(), ModContent.TileType<AcidRain2MusicboxTile>());


				swapTitleMusic = false;
				stopTitleMusic = false;
				titleMusicStopped = new ManualResetEvent(false);
			}
		}

        public override void Unload()
        {
			swapTitleMusic = stopTitleMusic = true;
			if (!Main.dedServ)
				titleMusicStopped.Set();
			Instance = null;
			titleMusicStopped = null;
			CalamityMusicConfig = null;
        }

        public override void PostSetupContent()
		{
			if (CalamityMusicConfig.TitleScreenMusicEnabled)
			{
				titleOverride = true;
				swapTitleMusic = true;
				if (!Main.dedServ)
				{
					titleMusicStopped.WaitOne();
					titleMusicStopped.Reset();
				}
			}

			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			Mod calamity = ModLoader.GetMod("CalamityMod");
			if (calamity != null && bossChecklist != null)
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
				"Brimstone Elemental", 
				ModContent.ItemType<BrimmyMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Aquatic Scourge", 
				ModContent.ItemType<AquaticScourgeMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Calamitas", 
				ModContent.ItemType<CalamitasMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Leviathan", 
				new List<int>() {ModContent.ItemType<LeviathanMusicbox>(), ModContent.ItemType<SirenMusicbox>()});

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
				new List<int>() {ModContent.ItemType<DoGMusicbox>(), ModContent.ItemType<DoGP2Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Yharon", 
				new List<int>() {ModContent.ItemType<Yharon2Musicbox>(), ModContent.ItemType<Yharon1Musicbox>(), ModContent.ItemType<Yharon3Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Supreme Calamitas", 
				new List<int>() {ModContent.ItemType<SCalGMusicbox>(), ModContent.ItemType<SCalLMusicbox>(), ModContent.ItemType<SCalEMusicbox>(), ModContent.ItemType<SCalAMusicbox>()});

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

		public static void Swap<T>(ref T a, ref T b)
		{
			var tmp = a;
			a = b;
			b = tmp;
		}

		public override void Close()
		{
			// Close isn't called on the main thread. Who doesn't love a bit of thread safety
			// Close may be called even if we didn't reach PostSetupContent, so don't try and stop a music track which hasn't been loaded or played
			if (!Main.dedServ && Main.music[MusicID.Title] == GetMusic("Sounds/Music/Calamity"))
			{
				stopTitleMusic = swapTitleMusic = true;
				titleMusicStopped.WaitOne();
			}
			base.Close();
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (!Main.dedServ && CalamityMusicConfig != null)
			{
				if (titleOverride != CalamityMusicConfig.TitleScreenMusicEnabled)
				{
					swapTitleMusic = true;
					titleOverride = !titleOverride;
				}
				if (Main.ActivePlayersCount != 0 && needsSwap)
				{
					swapTitleMusic = true;
					needsSwap = false;
				}
				if (swapTitleMusic)
				{
					int slot = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity");

					Swap(ref Main.music[MusicID.Title], ref Main.music[slot]);
					Swap(ref Main.musicFade[MusicID.Title], ref Main.musicFade[slot]);

					swapTitleMusic = false;

					if (stopTitleMusic && Main.music[slot] is MusicStreaming)
						((MusicStreaming)Main.music[slot]).Dispose();

					titleMusicStopped.Set();
				}
			}
		}

		public override void PreSaveAndQuit()
		{
			swapTitleMusic = needsSwap = true;
		}

		internal static void SaveConfig(Config CalamityMusicConfig)
		{
			// in-game ModConfig saving from mod code is not supported yet in tmodloader, and subject to change, so we need to be extra careful.
			// This code only supports client configs, and doesn't call onchanged. It also doesn't support ReloadRequired or anything else.
			MethodInfo saveMethodInfo = typeof(ConfigManager).GetMethod("Save", BindingFlags.Static | BindingFlags.NonPublic);
			if (saveMethodInfo != null)
				saveMethodInfo.Invoke(null, new object[] { CalamityMusicConfig });
			else
				Instance.Logger.Warn("In-game SaveConfig failed, code update required");
		}

		public static void MusicBoxShortcut(int type, int i, int j, int tileX, int tileY)
        {
            int x = i - Main.tile[i, j].frameX / 18 % tileX;
            int y = j - Main.tile[i, j].frameY / 18 % tileY;
            for (int l = x; l < x + tileX; l++)
            {
                for (int m = y; m < y + tileY; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == type)
                    {
                        if (Main.tile[l, m].frameX < (18 * tileX))
                        {
                            Main.tile[l, m].frameX += (short)(18 * tileX);
                        }
                        else
                        {
                            Main.tile[l, m].frameX -= (short)(18 * tileX);
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                for (int k = 0; k < tileX; k++)
                {
                    for (int l = 0; l < tileY; l++)
                    {
                        Wiring.SkipWire(x + k, y + l);
                    }
                }
            }
        }
	}
}
