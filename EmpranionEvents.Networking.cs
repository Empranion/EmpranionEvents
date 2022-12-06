using System.IO;
using EmpranionEvents.Common.Networking;
using EmpranionEvents.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public const byte PlayerTeleportMessageType = 1;
    
    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        switch (reader.ReadByte()) {
            case PlayerTeleportMessageType:
                new PlayerTeleportPacket().HandlePacket(reader, whoAmI);
                break;
        }
    }
}