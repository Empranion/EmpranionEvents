using Terraria;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Systems;

public sealed class GamemodeSystem : ModSystem
{
    public static bool IsGameActive { get; private set; }

    public override void PreUpdateWorld() {
        if (IsGameActive) {
            Main.raining = false;
            Main.eclipse = false;
            Main.bloodMoon = false;
        }
    }

    public static void StartGame() {
        IsGameActive = true;
    }

    public static void EndGame() {
        IsGameActive = false;
    }
}