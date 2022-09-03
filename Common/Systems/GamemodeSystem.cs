using Terraria.ModLoader;

namespace EmpranionBR.Common.Systems;

public sealed class GamemodeSystem : ModSystem
{
    public static bool GameActive { get; private set; }

    public static void StartGame() {
        GameActive = true;
    }

    public static void StopGame() {
        GameActive = false;
    }
}