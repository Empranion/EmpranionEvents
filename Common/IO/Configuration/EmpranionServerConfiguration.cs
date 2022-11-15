using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EmpranionEvents.Common.IO.Configuration;

public sealed class EmpranionServerConfiguration : ModConfig
{
    [DefaultValue(100)]
    [Range(100, 500)]
    [Slider]
    public int LobbyHeight;

    [DefaultValue(100)]
    [Range(100, 500)]
    [Slider]
    public int LobbyWidth;

    public override ConfigScope Mode => ConfigScope.ServerSide;
}