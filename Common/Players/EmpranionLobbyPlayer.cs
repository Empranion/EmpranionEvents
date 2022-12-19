using EmpranionEvents.Common.Systems;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Players;

public sealed class EmpranionLobbyPlayer : ModPlayer
{
    public override void PostUpdate() {
        if (EmpranionGameSystem.IsGameActive) {
            return;
        }
        
        ConstrainLobbyPosition();
    }

    private void ConstrainLobbyPosition() {
        int width = EmpranionEvents.Config.LobbyWidth;
        int height = EmpranionEvents.Config.LobbyHeight;

        Vector2 spawnTile = new Vector2(Main.spawnTileX, Main.spawnTileY) * 16f;
        Vector2 halfSize = new Vector2(width, height) * 16f / 2f;

        const float centerOffset = 24f;

        float minX = spawnTile.X - halfSize.X;
        float maxX = spawnTile.X + halfSize.X - centerOffset;

        float minY = spawnTile.Y - halfSize.Y;
        float maxY = spawnTile.Y + halfSize.Y - centerOffset;

        Player.position.X = MathHelper.Clamp(Player.position.X, minX, maxX);
        Player.position.Y = MathHelper.Clamp(Player.position.Y, minY, maxY);
    }
}