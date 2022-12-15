using EmpranionEvents.Common.Systems;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals.Tiles;

public sealed class EmpranionLobbyTile : GlobalTile
{
    public override bool CanKillTile(int i, int j, int type, ref bool blockDamaged) {
        return CanBeDestroyed(i, j);
    }

    public override bool CanExplode(int i, int j, int type) {
        return CanBeDestroyed(i, j);
    }

    private static bool CanBeDestroyed(int i, int j) {
        return !EmpranionGameSystem.IsGameActive && !EmpranionEvents.LobbyRectangle.Contains(new Point(i, j));
    }
}