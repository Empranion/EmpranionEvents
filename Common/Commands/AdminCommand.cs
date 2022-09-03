using EmpranionBR.Common.Id;
using EmpranionBR.Utility;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public abstract class AdminCommand : ModCommand
{
    public override sealed CommandType Type { get; } = CommandType.Chat;

    public override sealed void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (UserUtils.IsDefaultUser) {
                caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.PermissionErrorMessage"), ColorId.ErrorColor);
                return;
            }

            SafeAction(caller, input, args);
        }
        catch (UsageException exception) {
            caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.ExecutionErrorMessage"), ColorId.ErrorColor);
        }
    }

    public abstract void SafeAction(CommandCaller caller, string input, string[] args);
}