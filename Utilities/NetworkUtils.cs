using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Terraria;

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
}