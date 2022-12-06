using System.IO;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    // TODO: Lay out a structure for handling mod packets and messages through the server and remaining clients.
    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        byte messageType = reader.ReadByte();

        switch (messageType) {
            default:
                Logger.Warn($"{NamePrefix} Unknown message type: {messageType}");

                break;
        }
    }
}