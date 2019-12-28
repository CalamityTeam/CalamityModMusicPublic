using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;

        public CalamityModMusic()
    	{
            Instance = this;
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                //Boss Music
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AquaticScourge"), ItemType("AquaticScourgeMusicbox"), TileType("AquaticScourgeMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astrageldon"), ItemType("AstrageldonMusicbox"), TileType("AstrageldonMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumDeus"), ItemType("AstrumDeusMusicbox"), TileType("AstrumDeusMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeftAlone"), ItemType("BrimmyMusicbox"), TileType("BrimmyMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Murderswarm"), ItemType("BumblebirbMusicbox"), TileType("BumblebirbMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas"), ItemType("CalamitasMusicbox"), TileType("CalamitasMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Void"), ItemType("CeaselessVoidMusicbox"), TileType("CeaselessVoidMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crabulon"), ItemType("CrabulonMusicbox"), TileType("CrabulonMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Cryogen"), ItemType("CryogenMusicbox"), TileType("CryogenMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DesertScourge"), ItemType("DesertScourgeMusicbox"), TileType("DesertScourgeMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARON"), ItemType("Yharon1Musicbox"), TileType("Yharon1Musicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARONREBIRTH"), ItemType("Yharon2Musicbox"), TileType("Yharon2Musicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DragonGod"), ItemType("Yharon3Musicbox"), TileType("Yharon3Musicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RUIN"), ItemType("PolterghastMusicbox"), TileType("PolterghastMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Guardians"), ItemType("ProfanedGuardianMusicbox"), TileType("ProfanedGuardianMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ProvidenceTheme"), ItemType("ProvidenceMusicbox"), TileType("ProvidenceMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager"), ItemType("RavagerMusicbox"), TileType("RavagerMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Signus"), ItemType("SignusMusicbox"), TileType("SignusMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SirenLure"), ItemType("SirenIdleMusicbox"), TileType("SirenIdleMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Siren"), ItemType("SirenMusicbox"), TileType("SirenMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren"), ItemType("LeviathanMusicbox"), TileType("LeviathanMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Weaver"), ItemType("StormWeaverMusicbox"), TileType("StormWeaverMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCG"), ItemType("SCalGMusicbox"), TileType("SCalGMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCL"), ItemType("SCalLMusicbox"), TileType("SCalLMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCE"), ItemType("SCalEMusicbox"), TileType("SCalEMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCA"), ItemType("SCalAMusicbox"), TileType("SCalAMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ScourgeofTheUniverse"), ItemType("DoGMusicbox"), TileType("DoGMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UniversalCollapse"), ItemType("DoGP2Musicbox"), TileType("DoGP2Musicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind"), ItemType("HiveMindMusicbox"), TileType("HiveMindMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BloodCoagulant"), ItemType("PerforatorMusicbox"), TileType("PerforatorMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PlaguebringerGoliath"), ItemType("PlaguebringerMusicbox"), TileType("PlaguebringerMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod"), ItemType("SlimeGodMusicbox"), TileType("SlimeGodMusicbox"));

				//Biome Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sulphur"), ItemType("SulphurousMusicbox"), TileType("SulphurousMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheAbyss"), ItemType("HigherAbyssMusicbox"), TileType("HigherAbyssMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheDeepAbyss"), ItemType("AbyssLowerMusicbox"), TileType("AbyssLowerMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheVoid"), ItemType("VoidMusicbox"), TileType("VoidMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astral"), ItemType("AstralMusicbox"), TileType("AstralMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity"), ItemType("CalamityMusicbox"), TileType("CalamityMusicbox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crag"), ItemType("CragMusicbox"), TileType("CragMusicbox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea"), ItemType("SunkenSeaMusicbox"), TileType("SunkenSeaMusicbox"));
            }
        }

        public override void Unload()
        {
            Instance = null;
        }

        public override void PostSetupContent()
		{
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			Mod calamity = ModLoader.GetMod("CalamityMod");
			if (calamity != null && bossChecklist != null)
			{
				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Desert Scourge", 
				ItemType("DesertScourgeMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Giant Clam", 
				ItemType("SunkenSeaMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Crabulon", 
				ItemType("CrabulonMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Hive Mind", 
				ItemType("HiveMindMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"The Perforators", 
				ItemType("PerforatorMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Slime God", 
				ItemType("SlimeGodMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Cryogen", 
				ItemType("CryogenMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Brimstone Elemental", 
				ItemType("BrimmyMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Aquatic Scourge", 
				ItemType("AquaticScourgeMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Calamitas", 
				ItemType("CalamitasMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Leviathan", 
				new List<int>() {ItemType("LeviathanMusicbox"), ItemType("SirenMusicbox")});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Aureus", 
				ItemType("AstrageldonMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Plaguebringer Goliath", 
				ItemType("PlaguebringerMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ravager", 
				ItemType("RavagerMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Deus", 
				ItemType("AstrumDeusMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Profaned Guardians", 
				ItemType("ProfanedGuardianMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Bumblebirb", 
				ItemType("BumblebirbMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Providence", 
				ItemType("ProvidenceMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ceaseless Void", 
				ItemType("CeaselessVoidMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Storm Weaver", 
				ItemType("StormWeaverMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Signus", 
				ItemType("SignusMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Polterghast", 
				ItemType("PolterghastMusicbox"));

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Devourer of Gods", 
				new List<int>() {ItemType("DoGMusicbox"), ItemType("DoGP2Musicbox")});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Yharon", 
				new List<int>() {ItemType("Yharon2Musicbox"), ItemType("Yharon1Musicbox"), ItemType("Yharon3Musicbox")});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Supreme Calamitas", 
				new List<int>() {ItemType("SCalGMusicbox"), ItemType("SCalLMusicbox"), ItemType("SCalEMusicbox"), ItemType("SCalAMusicbox")});
			}
		}
    }
}
