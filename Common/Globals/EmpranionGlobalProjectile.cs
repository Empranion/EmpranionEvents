using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Globals;

public sealed class EmpranionGlobalProjectile : GlobalProjectile
{
    public override void SetDefaults(Projectile projectile) {
        switch (projectile.type) {
            case ProjectileID.Starfury:
                projectile.damage = 32;
                projectile.velocity *= 14;
                break;
        }
    }
}