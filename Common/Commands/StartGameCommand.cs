using EmpranionEvents.Common.Systems;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class StartGameCommand : AdminCommand
{
    public override string Command => "startgame";

    public override string Usage => "/startgame";

    public override string Description => "Attempts to start a game";

    protected override void SafeAction(CommandCaller caller, string input, string[] args) {
        ModPacket packet = Mod.GetPacket();
        packet.Write((byte)EmpranionEvents.PlayerTeleportMessageType);
        packet.Write((float)Main.spawnTileX * 16f);
        packet.Write((float)Main.spawnTileY * 16f); 
        packet.Send();
        
        if (EmpranionGameSystem.IsGameActive) {
            return;
        }

        EmpranionGameSystem.StartGame();
    }
}