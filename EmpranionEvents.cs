using System.Collections.Immutable;
using Steamworks;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed class EmpranionEvents : Mod
{
    // Lets keep those constant for testing purposes, for now. Soon to be configurable.
    public const int GraceDuration = 30000;
    public const int QueenBeeDespawnRange = 64 * 16;
    
    public static readonly ImmutableArray<ulong> AdminIds = ImmutableArray.Create(
        76561198804876877UL,
        76561198845331461UL,
        76561199021868045UL
    );
    
    public static readonly ulong CurrentId = SteamUser.GetSteamID().m_SteamID;

    public static EmpranionEvents Instance => ModContent.GetInstance<EmpranionEvents>();
}