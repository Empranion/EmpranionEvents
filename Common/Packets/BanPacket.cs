using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace EmpranionEvents.Common.Packets;

public readonly struct BanPacket : IPacket
{
    public void Handle(BinaryReader reader, int whoAmI) {
        int playerIndex = reader.ReadInt32();

        Netplay.AddBan(playerIndex);
        NetMessage.SendData(MessageID.Kick, playerIndex, -1, NetworkText.FromKey("CLI.BanMessage"));
    }
}