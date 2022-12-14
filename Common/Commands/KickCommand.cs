using System;
using EmpranionEvents.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Commands;

public sealed class KickCommand : ModCommand
{
    public override CommandType Type => CommandType.Chat;

    public override string Command => "kick";

    public override string Usage => "/kick <name>";

    public override string Description => "Kicks a player from the server";

    public override void Action(CommandCaller caller, string input, string[] args) {
        try {
            if (!EmpranionEvents.IsHost) {
                caller.Reply("Insufficient permissions to execute this command.", EmpranionEvents.ErrorColor);

                return;
            }

            string name = string.Join(" ", args);

            if (!string.IsNullOrEmpty(name) && NetworkUtils.TryGetPlayer(name, out Player player)) {
                ModPacket packet = Mod.GetPacket();
                packet.Write(EmpranionEvents.KickPlayerMessageType);
                packet.Write(player.whoAmI);
                packet.Send();

                caller.Reply($"Kicked {name} from the server.", EmpranionEvents.SuccessColor);
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