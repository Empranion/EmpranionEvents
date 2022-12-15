using System.IO;
using EmpranionEvents.Common.Packets;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public const byte KickPlayerMessageType = 0;
    public const byte BanPlayerMessageType = 1;
    public const byte ToggleGameMessageType = 2;

    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        byte messageType = reader.ReadByte();

        switch (messageType) {
            case KickPlayerMessageType:
                new KickPacket().Handle(reader, whoAmI);

                break;

            case BanPlayerMessageType:
                new BanPacket().Handle(reader, whoAmI);

                break;

            case ToggleGameMessageType:
                new ToggleGamePacket().Handle(reader, whoAmI);

                break;

            default:
                Logger.Warn($"Unknown message type: {messageType}");

                break;
        }
    }
}