using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("ProfanedGuardianMusicbox")]
    public class ProfanedGuardiansMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.ProfanedGuardiansMusicBox>();
    }
}
