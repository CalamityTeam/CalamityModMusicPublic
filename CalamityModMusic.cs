using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using CalamityModMusic.Tiles;
using CalamityModMusic.Items.Placeables;

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
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AquaticScourge"), ModContent.ItemType<Items.Placeables.AquaticScourgeMusicbox>(), ModContent.TileType<Tiles.AquaticScourgeMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astrageldon"), ModContent.ItemType<Items.Placeables.AstrageldonMusicbox>(), ModContent.TileType<Tiles.AstrageldonMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumDeus"), ModContent.ItemType<Items.Placeables.AstrumDeusMusicbox>(), ModContent.TileType<Tiles.AstrumDeusMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeftAlone"), ModContent.ItemType<Items.Placeables.BrimmyMusicbox>(), ModContent.TileType<Tiles.BrimmyMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Murderswarm"), ModContent.ItemType<Items.Placeables.BumblebirbMusicbox>(), ModContent.TileType<Tiles.BumblebirbMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas"), ModContent.ItemType<Items.Placeables.CalamitasMusicbox>(), ModContent.TileType<Tiles.CalamitasMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Void"), ModContent.ItemType<Items.Placeables.CeaselessVoidMusicbox>(), ModContent.TileType<Tiles.CeaselessVoidMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crabulon"), ModContent.ItemType<Items.Placeables.CrabulonMusicbox>(), ModContent.TileType<Tiles.CrabulonMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Cryogen"), ModContent.ItemType<Items.Placeables.CryogenMusicbox>(), ModContent.TileType<Tiles.CryogenMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DesertScourge"), ModContent.ItemType<Items.Placeables.DesertScourgeMusicbox>(), ModContent.TileType<Tiles.DesertScourgeMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARON"), ModContent.ItemType<Items.Placeables.Yharon1Musicbox>(), ModContent.TileType<Tiles.Yharon1Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YHARONREBIRTH"), ModContent.ItemType<Items.Placeables.Yharon2Musicbox>(), ModContent.TileType<Tiles.Yharon2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DragonGod"), ModContent.ItemType<Items.Placeables.Yharon3Musicbox>(), ModContent.TileType<Tiles.Yharon3Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RUIN"), ModContent.ItemType<Items.Placeables.PolterghastMusicbox>(), ModContent.TileType<Tiles.PolterghastMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Guardians"), ModContent.ItemType<Items.Placeables.ProfanedGuardianMusicbox>(), ModContent.TileType<Tiles.ProfanedGuardianMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ProvidenceTheme"), ModContent.ItemType<Items.Placeables.ProvidenceMusicbox>(), ModContent.TileType<Tiles.ProvidenceMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager"), ModContent.ItemType<Items.Placeables.RavagerMusicbox>(), ModContent.TileType<Tiles.RavagerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Signus"), ModContent.ItemType<Items.Placeables.SignusMusicbox>(), ModContent.TileType<Tiles.SignusMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SirenLure"), ModContent.ItemType<Items.Placeables.SirenIdleMusicbox>(), ModContent.TileType<Tiles.SirenIdleMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Siren"), ModContent.ItemType<Items.Placeables.SirenMusicbox>(), ModContent.TileType<Tiles.SirenMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren"), ModContent.ItemType<Items.Placeables.LeviathanMusicbox>(), ModContent.TileType<Tiles.LeviathanMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Weaver"), ModContent.ItemType<Items.Placeables.StormWeaverMusicbox>(), ModContent.TileType<Tiles.StormWeaverMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCG"), ModContent.ItemType<Items.Placeables.SCalGMusicbox>(), ModContent.TileType<Tiles.SCalGMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCL"), ModContent.ItemType<Items.Placeables.SCalLMusicbox>(), ModContent.TileType<Tiles.SCalLMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCE"), ModContent.ItemType<Items.Placeables.SCalEMusicbox>(), ModContent.TileType<Tiles.SCalEMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SCA"), ModContent.ItemType<Items.Placeables.SCalAMusicbox>(), ModContent.TileType<Tiles.SCalAMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ScourgeofTheUniverse"), ModContent.ItemType<Items.Placeables.DoGMusicbox>(), ModContent.TileType<Tiles.DoGMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UniversalCollapse"), ModContent.ItemType<Items.Placeables.DoGP2Musicbox>(), ModContent.TileType<Tiles.DoGP2Musicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind"), ModContent.ItemType<Items.Placeables.HiveMindMusicbox>(), ModContent.TileType<Tiles.HiveMindMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BloodCoagulant"), ModContent.ItemType<Items.Placeables.PerforatorMusicbox>(), ModContent.TileType<Tiles.PerforatorMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PlaguebringerGoliath"), ModContent.ItemType<Items.Placeables.PlaguebringerMusicbox>(), ModContent.TileType<Tiles.PlaguebringerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod"), ModContent.ItemType<Items.Placeables.SlimeGodMusicbox>(), ModContent.TileType<Tiles.SlimeGodMusicbox>());

				//Biome Music
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Sulphur"), ModContent.ItemType<Items.Placeables.SulphurousMusicbox>(), ModContent.TileType<Tiles.SulphurousMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheAbyss"), ModContent.ItemType<Items.Placeables.HigherAbyssMusicbox>(), ModContent.TileType<Tiles.HigherAbyssMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheDeepAbyss"), ModContent.ItemType<Items.Placeables.AbyssLowerMusicbox>(), ModContent.TileType<Tiles.AbyssLowerMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/TheVoid"), ModContent.ItemType<Items.Placeables.VoidMusicbox>(), ModContent.TileType<Tiles.VoidMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astral"), ModContent.ItemType<Items.Placeables.AstralMusicbox>(), ModContent.TileType<Tiles.AstralMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstralUnderground"), ModContent.ItemType<Items.Placeables.AstralUndergroundMusicbox>(), ModContent.TileType<Tiles.AstralUndergroundMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity"), ModContent.ItemType<Items.Placeables.CalamityMusicbox>(), ModContent.TileType<Tiles.CalamityMusicbox>());
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crag"), ModContent.ItemType<Items.Placeables.CragMusicbox>(), ModContent.TileType<Tiles.CragMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea"), ModContent.ItemType<Items.Placeables.SunkenSeaMusicbox>(), ModContent.TileType<Tiles.SunkenSeaMusicbox>());
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
				ModContent.ItemType<Items.Placeables.DesertScourgeMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Giant Clam", 
				ModContent.ItemType<Items.Placeables.SunkenSeaMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Crabulon", 
				ModContent.ItemType<Items.Placeables.CrabulonMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Hive Mind", 
				ModContent.ItemType<Items.Placeables.HiveMindMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"The Perforators", 
				ModContent.ItemType<Items.Placeables.PerforatorMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Slime God", 
				ModContent.ItemType<Items.Placeables.SlimeGodMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Cryogen", 
				ModContent.ItemType<Items.Placeables.CryogenMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Brimstone Elemental", 
				ModContent.ItemType<Items.Placeables.BrimmyMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Aquatic Scourge", 
				ModContent.ItemType<Items.Placeables.AquaticScourgeMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Calamitas", 
				ModContent.ItemType<Items.Placeables.CalamitasMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Leviathan", 
				new List<int>() {ModContent.ItemType<Items.Placeables.LeviathanMusicbox>(), ModContent.ItemType<Items.Placeables.SirenMusicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Aureus", 
				ModContent.ItemType<Items.Placeables.AstrageldonMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Plaguebringer Goliath", 
				ModContent.ItemType<Items.Placeables.PlaguebringerMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ravager", 
				ModContent.ItemType<Items.Placeables.RavagerMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Deus", 
				ModContent.ItemType<Items.Placeables.AstrumDeusMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Profaned Guardians", 
				ModContent.ItemType<Items.Placeables.ProfanedGuardianMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Bumblebirb", 
				ModContent.ItemType<Items.Placeables.BumblebirbMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Providence", 
				ModContent.ItemType<Items.Placeables.ProvidenceMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ceaseless Void", 
				ModContent.ItemType<Items.Placeables.CeaselessVoidMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Storm Weaver", 
				ModContent.ItemType<Items.Placeables.StormWeaverMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Signus", 
				ModContent.ItemType<Items.Placeables.SignusMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Polterghast", 
				ModContent.ItemType<Items.Placeables.PolterghastMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Devourer of Gods", 
				new List<int>() {ModContent.ItemType<Items.Placeables.DoGMusicbox>(), ModContent.ItemType<Items.Placeables.DoGP2Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Yharon", 
				new List<int>() {ModContent.ItemType<Items.Placeables.Yharon2Musicbox>(), ModContent.ItemType<Items.Placeables.Yharon1Musicbox>(), ModContent.ItemType<Items.Placeables.Yharon3Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Supreme Calamitas", 
				new List<int>() {ModContent.ItemType<Items.Placeables.SCalGMusicbox>(), ModContent.ItemType<Items.Placeables.SCalLMusicbox>(), ModContent.ItemType<Items.Placeables.SCalEMusicbox>(), ModContent.ItemType<Items.Placeables.SCalAMusicbox>()});
			}
		}
    }
}
