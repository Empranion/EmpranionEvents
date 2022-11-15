using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals;

public sealed class EmpranionGlobalTile : GlobalTile
{
    public override bool CreateDust(int i, int j, int type, ref int dustType) {
        if (!CanBeBroken(i, j)) {
            dustType = DustID.Firework_Red;
        }

        return true;
    }

    public override bool CanExplode(int i, int j, int type) {
        return CanBeBroken(i, j);
    }

    public override bool CanKillTile(int i, int j, int type, ref bool blockDamaged) {
        return CanBeBroken(i, j);
    }

    private static bool CanBeBroken(int i, int j) {
        return EmpranionSystem.IsGameActive && EmpranionSystem.LobbyArea.Contains(i, j) ? false : true;
    }
}