using System.IO;
using EmpranionEvents.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.UI.Chat;

namespace EmpranionEvents.Common.Networking;

public readonly struct PlayerTeleportPacket : IPacketHandler
{
    public void HandlePacket(BinaryReader reader, int fromWho) {
        float x = reader.ReadSingle();
        float y = reader.ReadSingle();

        ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral($"Position: {x} @ {y}"), Color.White);
        ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral($"From who: {fromWho}"), Color.White);
    }
}