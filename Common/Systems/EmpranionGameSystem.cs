using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Systems;

public sealed class EmpranionGameSystem : ModSystem
{
    public override void PostUpdateWorld() {
        int width = EmpranionEvents.ServerConfig.LobbyWidth ;
        int height = EmpranionEvents.ServerConfig.LobbyHeight;

        Vector2 spawnTile = new Vector2(Main.spawnTileX, Main.spawnTileY) * 16f;
        Vector2 halfSize = new Vector2(width, height) * 16f / 2f;
        
        Dust.QuickBox(spawnTile - halfSize, spawnTile + halfSize, 64, Color.Red, null);
    }
}