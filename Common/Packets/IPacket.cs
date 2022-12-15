using System.IO;

namespace EmpranionEvents.Common.Packets;

public interface IPacket
{
    void Handle(BinaryReader reader, int whoAmI);
}