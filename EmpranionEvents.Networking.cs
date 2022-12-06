using System.IO;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        byte messageType = reader.ReadByte();

        switch (messageType) {
            default:
                Logger.Warn($"{NamePrefix} Unknown message type: {messageType}");

                break;
        }
    }
}