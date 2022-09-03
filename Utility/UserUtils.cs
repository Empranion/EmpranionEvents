using System.Linq;
using EmpranionBR.Common.Id;
using Steamworks;

namespace EmpranionBR.Utility;

public static class UserUtils
{
    public static string Username => SteamFriends.GetPersonaName();

    public static ulong UserId => SteamUser.GetSteamID().m_SteamID;

    public static bool IsAdminUser => AdminId.AllIds.Contains(UserId);

    public static bool IsDefaultUser => !AdminId.AllIds.Contains(UserId);
}