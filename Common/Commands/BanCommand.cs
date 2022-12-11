using System;
using EmpranionEvents.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class BanCommand : ModCommand
{
    public override CommandType Type => CommandType.Chat;

    public override string Command => "ban";

    public override string Usage => "/ban <name>";
    
    public override string Description => "Bans a player from the server";

    public override void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (!EmpranionEvents.IsHost) {
                caller.Reply("Insufficient permissions to execute this command.", EmpranionEvents.ErrorColor);

                return;
            }

            string name = args[0];

            if (!string.IsNullOrEmpty(name) && NetworkUtils.TryGetPlayer(name, out Player player)) {
                NetworkUtils.BanPlayer(player);
                caller.Reply($"Banned {name} from the server.", EmpranionEvents.SuccessColor);
            }
            else {
                caller.Reply($"Couldn't find any player of name {name} in the server.", EmpranionEvents.ErrorColor);
            }
        }
        catch (Exception exception) {
            caller.Reply(exception.Message, EmpranionEvents.ErrorColor);
        }
    }
}