using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public sealed class EndGameCommand : AdminCommand
{
    public override string Command { get; } = "endgame";

    public override string Usage { get; } = "/endgame";
    
    public override string Description { get; } = "Attempts to end a game";

    public override void SafeAction(CommandCaller caller, string input, string[] args) { }
}