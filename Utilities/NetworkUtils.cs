using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;

namespace EmpranionEvents.Utilities;

public static class NetworkUtils
{
    public static IEnumerable<Player> GetPlayers(Predicate<Player> predicate = null) {
        for (int i = 0; i < Main.maxPlayers; i++) {
            Player player = Main.player[i];

            if (player != null && player.active && predicate.Invoke(player)) {
                yield return player;
            }
        }
    }

    public static IEnumerable<Player> GetPlayersAlive() {
        return GetPlayers(x => !x.dead && !x.ghost);
    }

    public static IEnumerable<Player> GetDeadPlayers() {
        return GetPlayers(x => x.dead || x.ghost);
    }
}