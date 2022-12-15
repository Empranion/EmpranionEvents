using System.Collections.Immutable;
using EmpranionEvents.Common.Config;
using Microsoft.Xna.Framework;
using Steamworks;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionEvents;

public sealed partial class EmpranionEvents : Mod
{
    public static readonly ImmutableArray<ulong> AdminIds = ImmutableArray.Create(
        76561198804876877UL,
        76561198845331461UL,
        76561199021868045UL
    );

    public static readonly Color ErrorColor = new(243, 99, 99);
    public static readonly Color SuccessColor = new(159, 246, 140);

    public static readonly ulong CurrentId = SteamUser.GetSteamID().m_SteamID;

    public static EmpranionEvents Instance => ModContent.GetInstance<EmpranionEvents>();
    public static EmpranionConfig Config => ModContent.GetInstance<EmpranionConfig>();

    public static int LobbyWidth => Config.LobbyWidth;
    public static int LobbyHeight => Config.LobbyHeight;

    public static Rectangle LobbyRectangle => new(Main.spawnTileX - LobbyWidth / 2, Main.spawnTileY - LobbyHeight / 2, LobbyWidth, LobbyHeight);

    public static bool IsHost => AdminIds.Contains(CurrentId);
}