using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Systems;

public sealed class EmpranionGameSystem : ModSystem
{
    public static bool IsGameActive { get; private set; }

    public override void PreUpdateWorld() {
        if (!IsGameActive) {
            return;
        }

        DisableEvents();
    }

    public static void StartGame() {
        IsGameActive = true;
    }

    public static void EndGame() {
        IsGameActive = false;
    }

    private static void DisableEvents() {
        Main.StopRain();
        Main.stopMoonEvent();
        Main.StopSlimeRain();

        Main.raining = false;
        Main.eclipse = false;
        Main.bloodMoon = false;

        Main.invasionType = InvasionID.None;
    }
}