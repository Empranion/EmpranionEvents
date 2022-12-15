using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace EmpranionEvents.Common.Packets;

public readonly struct KickPacket : IPacket
{
    public void Handle(BinaryReader reader, int whoAmI) {
        int playerIndex = reader.ReadInt32();

        NetMessage.SendData(MessageID.Kick, playerIndex, -1, NetworkText.FromKey("CLI.KickMessage"));
    }
}