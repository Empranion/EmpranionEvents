using System.Collections.Generic;
using System.Linq;
using Terraria;

namespace EmpranionBR.Utility;

public static class GameUtils
{
    public static IEnumerable<Player> ValidPlayers => Main.player.Where(player => player.active);

    public static IEnumerable<Player> PlayersAlive => ValidPlayers.Where(player => !player.dead && !player.ghost);
}