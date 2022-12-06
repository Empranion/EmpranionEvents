using System;
using System.Collections.Generic;
using Terraria;

namespace EmpranionEvents.Utilities;

public static class NetworkingUtils
{
    public static IEnumerable<Player> GetPlayers(Predicate<Player> predicate = null) {
        for (int i = 0; i < Main.maxPlayers; i++) {
            Player player = Main.player[i];

            if (player != null && player.active && predicate.Invoke(player)) {
                yield return player;
            }
        }
    }
}