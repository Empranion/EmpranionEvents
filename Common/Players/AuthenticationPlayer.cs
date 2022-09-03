using EmpranionBR.Common.Id;
using EmpranionBR.Utility;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Players;

public sealed class AuthenticationPlayer : ModPlayer
{
    internal string OldName { get; private set; }

    public override void OnEnterWorld(Player player) {
        Main.NewText($"Authenticated as: {UserUtils.Username}, player name temporarily changed!", ColorId.SuccessColor);

        OldName = player.name;
        player.name = UserUtils.Username;
    }

    private sealed class AuthenticationPlayerSystem : ModSystem
    {
        public override void PreSaveAndQuit() {
            Player player = Main.LocalPlayer;

            if (!player.TryGetModPlayer(out AuthenticationPlayer authenticationPlayer)) {
                return;
            }

            player.name = authenticationPlayer.OldName;
        }
    }
}