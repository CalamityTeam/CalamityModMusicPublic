using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("ProfanedGuardianMusicbox")]
    public class ProfanedGuardiansMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.ProfanedGuardiansMusicBox>();
    }
}
