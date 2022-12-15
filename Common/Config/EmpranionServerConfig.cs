using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EmpranionEvents.Common.Config;

public sealed class EmpranionServerConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Slider]
    [Increment(10)]
    [Range(100, 300)]
    [DefaultValue(100)]
    [Label("Lobby Width")]
    [Tooltip("Changes the width of the spawn lobby.")]
    public int LobbyWidth;

    [Slider]
    [Increment(10)]
    [Range(100, 300)]
    [DefaultValue(100)]
    [Label("Lobby Height")]
    [Tooltip("Changes the height of the spawn lobby.")]
    public int LobbyHeight;
}