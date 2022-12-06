using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals;

public sealed class EmpranionGlobalItem : GlobalItem
{
    public override void SetDefaults(Item item) {
        switch (item.type) {
            case ItemID.TentacleSpike:
                item.damage = 23;
                item.useTime = 20;
                item.useAnimation = 20;
                item.knockBack = 7f;
                break;

            case ItemID.BladeofGrass:
                item.damage = 27;
                item.knockBack = 2f;
                break;

            case ItemID.Starfury:
                item.damage = 19;
                break;

            case ItemID.BoneWhip:
                item.damage = 26;
                item.useTime = 40;
                item.useAnimation = 40;
                break;

            case ItemID.Rally:
                item.damage = 17;
                item.knockBack = 2f;
                break;

            case ItemID.AntlionClaw:
                item.damage = 18;
                break;

            case ItemID.LightsBane:
                item.damage = 20;
                item.scale *= 1.15f;
                break;

            case ItemID.HellfireArrow:
                item.damage = 12;
                break;

            case ItemID.Gladius:
                item.damage = 22;
                item.useTime = 6;
                item.useAnimation = 18;
                break;

            case ItemID.Flamelash:
                item.damage = 28;
                item.mana = 32;
                break;

            case ItemID.TheUndertaker:
                item.damage = 18;
                item.useTime = 21;
                item.useAnimation = 21;
                break;

            case ItemID.Flamarang:
                item.damage = 38;
                item.useTime = 16;
                item.useAnimation = 16;
                item.knockBack = 6.5f;
                item.shootSpeed = 11f;
                break;

            case ItemID.Harpoon:
                item.damage = 28;
                item.useTime = 24;
                item.useAnimation = 24;
                item.knockBack = 6.5f;
                break;

            case ItemID.AquaScepter:
                item.damage = 20;
                break;

            case ItemID.SpaceGun:
                item.damage = 23;
                item.useTime = 16;
                item.useAnimation = 16;
                break;

            case ItemID.FireWhip:
                item.damage = 34;
                item.useTime = 38;
                item.useAnimation = 38;
                break;

            case ItemID.BloodButcherer:
                item.damage = 23;
                break;

            case ItemID.FieryGreatsword:
                item.damage = 37;
                item.knockBack = 5.5f;
                break;

            case ItemID.DaedalusStormbow:
                item.damage = 33;
                item.useTime = 21;
                item.useAnimation = 21;
                break;

            case ItemID.ChainKnife:
                item.damage = 16;
                item.useTime = 16;
                item.useAnimation = 16;
                break;

            case ItemID.WhitePhaseblade:
            case ItemID.RedPhaseblade:
            case ItemID.OrangePhaseblade:
            case ItemID.YellowPhaseblade:
            case ItemID.GreenPhaseblade:
            case ItemID.BluePhaseblade:
            case ItemID.PurplePhaseblade:
                item.damage = 34;
                item.useTime = 24;
                item.useAnimation = 24;
                break;
        }
    }
}