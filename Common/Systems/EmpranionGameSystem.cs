using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Systems;

public sealed class EmpranionGameSystem : ModSystem
{
    public static bool IsGameActive { get; internal set; }

    public override void NetSend(BinaryWriter writer) {
        writer.Write(IsGameActive);
    }

    public override void NetReceive(BinaryReader reader) {
        IsGameActive = reader.ReadBoolean();
    }

    public override void PostUpdateWorld() {
        if (IsGameActive) {
            StopGameEvents();

            return;
        }
        
        SpawnLobbyDust();
    }

    private static void SpawnLobbyDust() {
        int width = EmpranionEvents.Config.LobbyWidth;
        int height = EmpranionEvents.Config.LobbyHeight;

        Vector2 spawnTile = new Vector2(Main.spawnTileX, Main.spawnTileY) * 16f;
        Vector2 halfSize = new Vector2(width, height) * 16f / 2f;

        Dust.QuickBox(spawnTile - halfSize, spawnTile + halfSize, 64, Color.Red, null);
    }

    private static void StopGameEvents() {
        Main.StopRain();
        Main.stopMoonEvent();
        Main.StopSlimeRain();

        Main.raining = false;
        Main.eclipse = false;
        Main.bloodMoon = false;

        Main.invasionType = InvasionID.None;
    }
}