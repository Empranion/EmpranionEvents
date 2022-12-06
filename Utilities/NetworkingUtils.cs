using System.Collections.Generic;
using Terraria;

namespace EmpranionEvents.Utilities;

public static class NetworkingUtils
{
    public static IEnumerable<Player> GetAllPlayers() {
        for (int i = 0; i < Main.maxPlayers; i++) {
            Player player = Main.player[i];

            if (player != null && player.active) {
                yield return player;
            }
        }
    }
}