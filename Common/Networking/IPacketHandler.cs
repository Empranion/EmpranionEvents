using System.IO;

namespace EmpranionEvents.Common.Networking;

public interface IPacketHandler
{
    void HandlePacket(BinaryReader reader, int fromWho);
}