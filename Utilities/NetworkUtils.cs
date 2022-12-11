using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace EmpranionEvents.Utilities; 

public static class NetworkUtils
{
    public static IEnumerable<Player> GetActivePlayers() {
        for (int i = 0; i < Main.maxPlayers; i++) {
            Player player = Main.player[i];

            if (player.active) {
                yield return player;
            }
        }
    }

    public static bool TryGetPlayer(string name, [NotNullWhen(true)] out Player player) {
        foreach (Player iterationPlayer in GetActivePlayers()) {
            if (iterationPlayer.name == name) {
                player = iterationPlayer;

                return true;
            }
        }

        player = null;
        
        return false;
    }
    
    public static void KickPlayer(Player player) {
        if (player.active) {
            NetMessage.SendData(MessageID.Kick, player.whoAmI, -1, NetworkText.FromKey("CLI.KickMessage"));
        }
    }

    public static void BanPlayer(Player player) {
        if (player.active) {
            Netplay.AddBan(player.whoAmI);
            NetMessage.SendData(MessageID.Kick, player.whoAmI, -1, NetworkText.FromKey("CLI.BanMessage"));
        }
    }
}