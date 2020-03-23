using Microsoft.Xna.Framework.Audio;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Threading;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityModMusic.Items.Placeables;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;
		internal static Config CalamityMusicConfig;

		private bool stopTitleMusic = false;
		private ManualResetEvent titleMusicStopped = new ManualResetEvent(false);

		private int customTitleMusicSlot;

		public CalamityModMusic()
    	{
            Instance = this;
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                //Boss Music
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
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARON"), ModContent.ItemType<Yharon1Musicbox>(), ModContent.TileType<Tiles.Yharon1Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARONREBIRTH"), ModContent.ItemType<Yharon2Musicbox>(), ModContent.TileType<Tiles.Yharon2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DragonGod"), ModContent.ItemType<Yharon3Musicbox>(), ModContent.TileType<Tiles.Yharon3Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RUIN"), ModContent.ItemType<PolterghastMusicbox>(), ModContent.TileType<Tiles.PolterghastMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Guardians"), ModContent.ItemType<ProfanedGuardianMusicbox>(), ModContent.TileType<Tiles.ProfanedGuardianMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ProvidenceTheme"), ModContent.ItemType<ProvidenceMusicbox>(), ModContent.TileType<Tiles.ProvidenceMusicbox>()); //Seamless
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager"), ModContent.ItemType<RavagerMusicbox>(), ModContent.TileType<Tiles.RavagerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Signus"), ModContent.ItemType<SignusMusicbox>(), ModContent.TileType<Tiles.SignusMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SirenLure"), ModContent.ItemType<SirenIdleMusicbox>(), ModContent.TileType<Tiles.SirenIdleMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Siren"), ModContent.ItemType<SirenMusicbox>(), ModContent.TileType<Tiles.SirenMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren"), ModContent.ItemType<LeviathanMusicbox>(), ModContent.TileType<Tiles.LeviathanMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Weaver"), ModContent.ItemType<StormWeaverMusicbox>(), ModContent.TileType<Tiles.StormWeaverMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCG"), ModContent.ItemType<SCalGMusicbox>(), ModContent.TileType<Tiles.SCalGMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCL"), ModContent.ItemType<SCalLMusicbox>(), ModContent.TileType<Tiles.SCalLMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCE"), ModContent.ItemType<SCalEMusicbox>(), ModContent.TileType<Tiles.SCalEMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCA"), ModContent.ItemType<SCalAMusicbox>(), ModContent.TileType<Tiles.SCalAMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ScourgeofTheUniverse"), ModContent.ItemType<DoGMusicbox>(), ModContent.TileType<Tiles.DoGMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UniversalCollapse"), ModContent.ItemType<DoGP2Musicbox>(), ModContent.TileType<Tiles.DoGP2Musicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind"), ModContent.ItemType<HiveMindMusicbox>(), ModContent.TileType<Tiles.HiveMindMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BloodCoagulant"), ModContent.ItemType<PerforatorMusicbox>(), ModContent.TileType<Tiles.PerforatorMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PlaguebringerGoliath"), ModContent.ItemType<PlaguebringerMusicbox>(), ModContent.TileType<Tiles.PlaguebringerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod"), ModContent.ItemType<SlimeGodMusicbox>(), ModContent.TileType<Tiles.SlimeGodMusicbox>());

				//Biome Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sulphur"), ModContent.ItemType<SulphurousMusicbox>(), ModContent.TileType<Tiles.SulphurousMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheAbyss"), ModContent.ItemType<HigherAbyssMusicbox>(), ModContent.TileType<Tiles.HigherAbyssMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheDeepAbyss"), ModContent.ItemType<AbyssLowerMusicbox>(), ModContent.TileType<Tiles.AbyssLowerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheVoid"), ModContent.ItemType<VoidMusicbox>(), ModContent.TileType<Tiles.VoidMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astral"), ModContent.ItemType<AstralMusicbox>(), ModContent.TileType<Tiles.AstralMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstralUnderground"), ModContent.ItemType<AstralUndergroundMusicbox>(), ModContent.TileType<Tiles.AstralUndergroundMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity"), ModContent.ItemType<CalamityMusicbox>(), ModContent.TileType<Tiles.CalamityMusicbox>()); //Seamless
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crag"), ModContent.ItemType<CragMusicbox>(), ModContent.TileType<Tiles.CragMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea"), ModContent.ItemType<SunkenSeaMusicbox>(), ModContent.TileType<Tiles.SunkenSeaMusicbox>());

				//Event Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AcidRain1"), ModContent.ItemType<AcidRain1Musicbox>(), ModContent.TileType<Tiles.AcidRain1MusicboxTile>()); //Seamless
			}
		}

        public override void Unload()
        {
            Instance = null;
        }

		private void setTitleMusic()
		{
			if (CalamityMusicConfig.TitleScreenMusicEnabled)
			{
				customTitleMusicSlot = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity");
				IL.Terraria.Main.UpdateAudio += il =>
				{
					var c = new ILCursor(il);
					c.GotoNext(MoveType.After, i => i.MatchLdfld<Main>("newMusic"));
					c.EmitDelegate<Func<int, int>>(newMusic => newMusic == MusicID.Title ? customTitleMusicSlot : newMusic);
				};
			}
		}

        public override void PostSetupContent()
		{
			setTitleMusic();

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
				"Bumblebirb", 
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
			}
		}
		public override void Close()
		{
			// Close isn't called on the main thread. Who doesn't love a bit of thread safety
			// Close may be called even if we didn't reach PostSetupContent, so don't try and stop a music track which hasn't been loaded or played
			if (customTitleMusicSlot > 0)
			{
				stopTitleMusic = true;
				titleMusicStopped.WaitOne();
			}
			base.Close();
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (stopTitleMusic || (!Main.gameMenu && customTitleMusicSlot != MusicID.Title && Main.ActivePlayerFileData != null && Main.ActiveWorldFileData != null))
			{
				if (!stopTitleMusic)
				{
					music = MusicID.Title;
				}

				// prevent our IL hook trying to play the track anymore
				// we could just remove our IL hook, but then we'd have to save it in a variable. tML removes it for us anyway
				customTitleMusicSlot = MusicID.Title;

				// stop the music if it's playing (which it probably is)
				var m = GetMusic("Sounds/Music/Calamity");
				if (m.IsPlaying)
					m.Stop(AudioStopOptions.Immediate);

				titleMusicStopped.Set();
				stopTitleMusic = false;
			}
		}

		public override void PreSaveAndQuit()
		{
			setTitleMusic();
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
