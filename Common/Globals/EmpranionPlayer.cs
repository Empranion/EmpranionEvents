using Terraria.DataStructures;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals;

public sealed class EmpranionPlayer : ModPlayer
{
    public override bool PreHurt(bool pvp,
        bool quiet,
        ref int damage,
        ref int hitDirection,
        ref bool crit,
        ref bool customDamage,
        ref bool playSound,
        ref bool genGore,
        ref PlayerDeathReason damageSource,
        ref int cooldownCounter) {
        if (damageSource.SourceNPCIndex == -1 && damageSource.SourcePlayerIndex == -1 && damageSource.SourceProjectileIndex == -1) {
            damage = (int)(damage * 0.75);
        }

        return damageSource.SourceProjectileType != 108;
    }
}