using System.IO;
using EmpranionEvents.Common.Systems;
using Terraria;
using Terraria.ID;

namespace EmpranionEvents.Common.Packets;

public readonly struct ToggleGamePacket : IPacket
{
    public void Handle(BinaryReader reader, int whoAmI) {
        bool value = reader.ReadBoolean();

        EmpranionGameSystem.IsGameActive = value;
        NetMessage.SendData(MessageID.WorldData);
    }
}