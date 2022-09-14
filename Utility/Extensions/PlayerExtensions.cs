using Terraria;

namespace EmpranionBR.Utility.Extensions;

public static class PlayerExtensions
{
    public static void ClearBuffs(this Player player) {
        for (int i = 0; i < player.buffType.Length; i++) {
            player.DelBuff(i);
        }
    }
}