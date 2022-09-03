using EmpranionBR.Common.Id;
using EmpranionBR.Common.Systems;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public sealed class StartGameCommand : AdminCommand
{
    public override string Command { get; } = "startgame";

    public override string Usage { get; } = "/startgame";

    public override string Description { get; } = "Attempts to start a game";

    public override void SafeAction(CommandCaller caller, string input, string[] args) {
        if (GamemodeSystem.GameActive) {
            caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.StartGameErrorMessage"), ColorId.ErrorColor);
            return;
        }

        GamemodeSystem.StartGame();

        caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.StartGameSuccessMessage"), ColorId.SuccessColor);
    }
}