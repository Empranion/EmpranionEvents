using EmpranionEvents.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class WarpLobbyCommand : AdminCommand
{
    public override string Command => "warplobby";

    public override string Usage => "/warplobby";

    public override string Description => "Warps all players to the lobby";

    protected override void SafeAction(CommandCaller caller, string input, string[] args) {
        int style = TeleportationStyleID.RecallPotion;

        float x = Main.spawnTileX * 16f;
        float y = (Main.spawnTileY - 4) * 16f;

        foreach (Player player in NetworkingUtils.GetAllPlayers()) {
            player.Teleport(new Vector2(x, y), style);
            NetMessage.SendData(MessageID.Teleport, -1, -1, null, 0, player.whoAmI, x, y, style);
        }
    }
}