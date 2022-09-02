using System.Linq;
using Microsoft.Xna.Framework;
using Steamworks;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionBR;

public sealed class EmpranionBRPlayer : ModPlayer
{
    public static readonly ulong[] AdminIds = {
        76561198804876877,
        76561198845331461,
        76561199021868045
    };

    public static bool IsAdmin => AdminIds.Contains(SteamUser.GetSteamID().m_SteamID);

    public override void OnEnterWorld(Player player) {
        SendAuthenticationMessage(player);
    }

    private static void SendAuthenticationMessage(Player player) {
        string message = $"Authenticated as: {player.name}.";

        if (IsAdmin) {
            message += " You have admin permissions!";
        }

        Main.NewText(message, new Color(212, 177, 99));
    }
}