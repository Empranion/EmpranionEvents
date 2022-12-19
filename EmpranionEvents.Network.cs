using System.Collections.Generic;
using System.IO;
using EmpranionEvents.Common.Packets;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public const byte KickPlayerMessageType = 0;
    public const byte BanPlayerMessageType = 1;

    private static Dictionary<byte, IPacket> packetsByType = new() {
        { KickPlayerMessageType, new KickPacket() },
        { BanPlayerMessageType, new BanPacket() }
    };

    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        byte messageType = reader.ReadByte();

        if (packetsByType.TryGetValue(messageType, out IPacket packet)) {
            packet.Handle(reader, whoAmI);

            return;
        }
        
        Logger.Warn($"Unknown message type: {messageType}");
    }
}