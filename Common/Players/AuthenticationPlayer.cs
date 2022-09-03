using EmpranionBR.Common.Id;
using EmpranionBR.Utility;
using Terraria;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Players;

public sealed class AuthenticationPlayer : ModPlayer
{
    public string OldName { get; private set; }

    public void AuthenticatePlayer() {
        OldName = Player.name;
        Player.name = UserUtils.Username;
        
        Main.NewText($"Authenticated as: {UserUtils.Username}, player name temporarily changed!", ColorId.SuccessColor);
    }

    public void UnauthenticatePlayer() {
        Player.name = UserUtils.Username;
    }
}