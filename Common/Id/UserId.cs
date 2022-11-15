using Steamworks;

namespace EmpranionEvents.Common.ID;

public static class UserId
{
    public static ulong CurrentId => SteamUser.GetSteamID().m_SteamID;

    public static readonly ulong[] AdminIds = {
        76561198804876877, // Naka
        76561198845331461, // Empranion
        76561199021868045 // Playering
    };
}