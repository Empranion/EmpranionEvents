using EmpranionEvents.Common.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class StartCommand : ModCommand
{
    public override CommandType Type => CommandType.Chat;

    public override string Command => "start";

    public override string Usage => "/start";

    public override string Description => "Attempts to start a new game";

    public override void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (!EmpranionEvents.IsHost) {
                caller.Reply("Insufficient permissions to execute this command.", EmpranionEvents.ErrorColor);

                return;
            }
            
            if (EmpranionGameSystem.IsGameActive) {
                caller.Reply("There is already an on-going game!", EmpranionEvents.ErrorColor);

                return;
            }
            
            caller.Reply("Successfully started a new game!", EmpranionEvents.SuccessColor);

            EmpranionGameSystem.IsGameActive = true;
            NetMessage.SendData(MessageID.WorldData);
        }
        catch (UsageException exception) {
            caller.Reply(exception.Message, EmpranionEvents.ErrorColor);
        }
    }
}