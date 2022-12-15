using EmpranionEvents.Utilities;
using Terraria;
using Terraria.ID;
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

            if (!string.IsNullOrEmpty(name) && NetworkUtils.TryGetPlayer(name, out Player player) && Main.netMode != NetmodeID.SinglePlayer) {
                ModPacket packet = Mod.GetPacket();
                packet.Write(EmpranionEvents.KickPlayerMessageType);
                packet.Write(player.whoAmI);
                packet.Send();

                caller.Reply($"Kicked {name} from the server.", EmpranionEvents.SuccessColor);

                return;
            }
            
            caller.Reply($"Couldn't find any player of name {name} in the server.", EmpranionEvents.ErrorColor);
        }
        catch (UsageException exception) {
            caller.Reply(exception.Message, EmpranionEvents.ErrorColor);
        }
    }
}