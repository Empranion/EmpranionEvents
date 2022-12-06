using EmpranionEvents.Common.Systems;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class EndGameCommand : AdminCommand
{
    public override string Command => "endgame";

    public override string Usage => "/endgame";

    public override string Description => "Attempts to end a game";

    protected override void SafeAction(CommandCaller caller, string input, string[] args) {
        if (!EmpranionGameSystem.IsGameActive) {
            return;
        }

        EmpranionGameSystem.EndGame();
    }
}