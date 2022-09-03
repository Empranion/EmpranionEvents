using EmpranionBR.Common.Id;
using EmpranionBR.Common.Systems;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public sealed class EndGameCommand : AdminCommand
{
    public override string Command { get; } = "endgame";

    public override string Usage { get; } = "/endgame";

    public override string Description { get; } = "Attempts to end a game";

    public override void SafeAction(CommandCaller caller, string input, string[] args) {
        if (!GamemodeSystem.GameActive) {
            caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.EndGameErrorMessage"), ColorId.ErrorColor);
            return;
        }

        GamemodeSystem.StopGame();
        
        caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.EndGameSuccessMessage"), ColorId.SuccessColor);
    }
}