using System.Linq;
using EmpranionBR.Common.Id;
using Steamworks;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Commands;

public abstract class AdminCommand : ModCommand
{
    public override sealed CommandType Type { get; } = CommandType.Chat;

    public override sealed void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (!AdminId.AllIds.Contains(SteamUser.GetSteamID().m_SteamID)) {
                caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.PermissionErrorMessage"), ColorId.CommandErrorColor);
                return;
            }

            SafeAction(caller, input, args);
        }
        catch (UsageException exception) {
            caller.Reply(Language.GetTextValue("Mods.EmpranionBR.Commands.ExecutionErrorMessage"), ColorId.CommandErrorColor);
        }
    }

    public abstract void SafeAction(CommandCaller caller, string input, string[] args);
}