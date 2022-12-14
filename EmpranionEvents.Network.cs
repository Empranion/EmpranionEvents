using System.Collections.Immutable;
using System.IO;
using EmpranionEvents.Utilities;
using Microsoft.Xna.Framework;
using Steamworks;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public const byte KickPlayerMessageType = 0;
    public const byte BanPlayerMessageType = 1;

    public override void HandlePacket(BinaryReader reader, int whoAmI) {
        byte messageType = reader.ReadByte();

        switch (messageType) {
            case KickPlayerMessageType:
                NetworkUtils.KickPlayer(Main.player[reader.ReadInt32()]);
                break;
            
            case BanPlayerMessageType:
                NetworkUtils.BanPlayer(Main.player[reader.ReadInt32()]);
                break;
        }
    }
}