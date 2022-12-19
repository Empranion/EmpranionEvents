using EmpranionEvents.Common.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class EndCommand : ModCommand
{
    public override CommandType Type => CommandType.Chat;

    public override string Command => "end";

    public override string Usage => "/end";

    public override string Description => "Attempts to end a on-going game";

    public override void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (!EmpranionEvents.IsHost) {
                caller.Reply("Insufficient permissions to execute this command.", EmpranionEvents.ErrorColor);

                return;
            }

            if (!EmpranionGameSystem.IsGameActive) {
                caller.Reply("No game is currently active!", EmpranionEvents.ErrorColor);

                return;
            }
            
            caller.Reply("Successfully ended the current game!", EmpranionEvents.SuccessColor);
            
            EmpranionGameSystem.IsGameActive = false;
            NetMessage.SendData(MessageID.WorldData);
        }
        catch (UsageException exception) {
            caller.Reply(exception.Message, EmpranionEvents.ErrorColor);
        }
    }
}