using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public abstract class HostCommand : ModCommand
{
    public override sealed CommandType Type => CommandType.Chat;

    public override sealed void Action(CommandCaller caller, string input, string[] args) {
        if (!EmpranionEvents.AdminIds.Contains(EmpranionEvents.CurrentId)) {
            return;
        }

        SafeAction(caller, input, args);
    }

    protected abstract void SafeAction(CommandCaller caller, string input, string[] args);
}