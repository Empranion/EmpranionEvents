using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals.Projectiles;

public sealed class EmpranionStatsProjectile : GlobalProjectile
{
    public override void SetDefaults(Projectile projectile) {
        switch (projectile.type) {
            case ProjectileID.Starfury:
                projectile.damage = 32;

                break;

            case ProjectileID.ThunderSpearShot:
                projectile.damage = 24;

                break;

            case ProjectileID.Explosives:
                projectile.hostile = false;
                projectile.friendly = false;
                projectile.damage = 0;

                break;
        }
    }
}