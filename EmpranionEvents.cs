using System.Collections.Immutable;
using Steamworks;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed class EmpranionEvents : Mod
{
    // TODO: Make all properties configurable within the host machine.
    public const int QueenBeeDespawnRange = 64 * 16;
    public const int GraceDuration = 30000;
    public const int LobbyWidth = 100;
    public const int LobbyHeight = 100;

    public const string Name = nameof(EmpranionEvents);
    public const string NamePrefix = Name + ":";

    public static readonly ImmutableArray<ulong> AdminIds = ImmutableArray.Create(
        76561198804876877UL,
        76561198845331461UL,
        76561199021868045UL
    );

    public static readonly ulong CurrentId = SteamUser.GetSteamID().m_SteamID;

    public static EmpranionEvents Instance => ModContent.GetInstance<EmpranionEvents>();
}