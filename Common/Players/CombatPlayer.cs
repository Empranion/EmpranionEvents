using Terraria.ModLoader;
using System.Reflection;
using Terraria;

namespace EmpranionBR.Common.Players;

public sealed class CombatPlayer : ModPlayer
{
    private static readonly FieldInfo showPvpInfo = typeof(Main).GetField("hidePVPIcons", BindingFlags.Static | BindingFlags.NonPublic);

    public void ForcePvp() {
        showPvpInfo.SetValue(null, true);

        Player.hostile = true;
    }

    public void UnforcePvp() {
        showPvpInfo.SetValue(null, false);
        
        Player.hostile = false;
    }
}