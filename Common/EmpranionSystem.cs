using EmpranionEvents.Common.IO.Configuration;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common;

public sealed class EmpranionSystem : ModSystem
{
    public static Rectangle LobbyArea => new(Main.spawnTileX - LobbyWidth / 2, Main.spawnTileY - LobbyHeight / 2, LobbyWidth, LobbyHeight);

    public static int LobbyWidth => ModContent.GetInstance<EmpranionServerConfiguration>().LobbyWidth;
    public static int LobbyHeight => ModContent.GetInstance<EmpranionServerConfiguration>().LobbyHeight;

    public static bool IsGameActive { get; private set; }

    public override void PreUpdateWorld() {
        if (IsGameActive) {
            DisableEvents();
            SpawnLobbyDust();
        }
    }

    public static void StartGame() {
        WarpToLobby();

        IsGameActive = true;
    }

    public static void EndGame() {
        WarpToLobby();

        IsGameActive = false;
    }

    private static void WarpToLobby() {
        for (int i = 0; i < Main.maxPlayers; i++) {
            Main.player[i].Teleport(new Vector2(Main.spawnTileX, Main.spawnTileY - 2) * 16f, TeleportationStyleID.RodOfDiscord);
        }
    }

    private static void DisableEvents() {
        Main.raining = false;
        Main.eclipse = false;
        Main.bloodMoon = false;
    }

    private static void SpawnLobbyDust() {
        int divisions = (LobbyWidth + LobbyHeight) / 2;

        Vector2 topLeft = LobbyArea.TopLeft() * 16f;
        Vector2 bottomRight = LobbyArea.BottomRight() * 16f;

        Dust.QuickBox(topLeft, bottomRight, divisions, Color.Red, null);
    }
}