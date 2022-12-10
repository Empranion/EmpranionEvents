using System.Collections.Immutable;
using Microsoft.Xna.Framework;
using Steamworks;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed class EmpranionEvents : Mod
{
    public static EmpranionEvents Instance => ModContent.GetInstance<EmpranionEvents>();
    
    public static readonly ImmutableArray<ulong> AdminIds = ImmutableArray.Create(
        76561198804876877UL,
        76561198845331461UL,
        76561199021868045UL
    );
    
    public static readonly Color ErrorColor = new(243, 99, 99);
    public static readonly Color SuccessColor = new(159, 246, 140);
    
    public static readonly ulong CurrentId = SteamUser.GetSteamID().m_SteamID;
}