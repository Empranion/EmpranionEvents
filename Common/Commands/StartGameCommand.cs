using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public sealed class StartCommand : AdminCommand
{
    public override string Command { get; } = "startgame";

    public override void SafeAction(CommandCaller caller, string input, string[] args) { }
}