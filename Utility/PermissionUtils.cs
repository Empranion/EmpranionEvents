using System.Linq;
using EmpranionBR.Common.Id;
using Steamworks;

namespace EmpranionBR.Utility;

public static class PermissionUtils
{
    public static bool HasPermissions => UserId.AdminIds.Contains(SteamUser.GetSteamID().m_SteamID);
}