using System.Linq;
using Steamworks;
using Terraria.ModLoader;

namespace EmpranionBR;

public sealed class EmpranionBRPlayer : ModPlayer
{
    public static readonly ulong[] AdminIds = {
        76561198804876877,
        76561198845331461
    };

    public static bool IsAdmin { get; } = AdminIds.Contains(SteamUser.GetSteamID().m_SteamID);
}