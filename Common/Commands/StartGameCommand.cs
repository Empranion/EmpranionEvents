using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class StartGameCommand : AdminCommand
{
    public override string Command => "startgame";

    public override string Usage => "/startgame";

    public override string Description => "Attempts to start a game";

    protected override void SafeAction(CommandCaller caller, string input, string[] args) {
        if (EmpranionSystem.IsGameActive) {
            return;
        }

        EmpranionSystem.StartGame();
    }
}