using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Globals.Items;

public sealed class EmpranionStatsItem : GlobalItem
{
    public override void SetDefaults(Item item) {
        switch (item.type) {
            case ItemID.Ale:
                item.buffTime = 14400;

                break;

            case ItemID.IceRod:
                item.value = 300000;

                break;

            case ItemID.Worm:
                item.bait = 30;

                break;

            case ItemID.EnchantedNightcrawler:
                item.bait = 40;

                break;

            case ItemID.WoodFishingPole:
                item.fishingPole = 10;

                break;

            case ItemID.ReinforcedFishingPole:
                item.fishingPole = 20;

                break;

            case ItemID.FisherofSouls:
                item.fishingPole = 25;

                break;

            case ItemID.Fleshcatcher:
                item.fishingPole = 27;

                break;

            case ItemID.ScarabFishingRod:
                item.fishingPole = 35;

                break;

            case ItemID.BloodFishingRod:
                item.fishingPole = 30;

                break;

            case ItemID.FiberglassFishingPole:
                item.fishingPole = 35;

                break;

            case ItemID.MechanicsRod:
                item.fishingPole = 40;

                break;

            case ItemID.SittingDucksFishingRod:
                item.fishingPole = 45;

                break;

            case ItemID.HotlineFishingHook:
                item.fishingPole = 50;

                break;

            case ItemID.GoldenFishingRod:
                item.fishingPole = 100;

                break;

            case ItemID.Flamarang:
                item.damage = 49;
                item.useTime = 15;
                item.useAnimation = 15;
                item.shootSpeed = 15.75f;

                break;

            case ItemID.TheUndertaker:
                item.damage = 18;
                item.useTime = 21;
                item.useAnimation = 21;

                break;

            case ItemID.Harpoon:
                item.damage = 34;

                break;

            case ItemID.AquaScepter:
                item.damage = 20;

                break;

            case ItemID.SpaceGun:
                item.damage = 23;
                item.useTime = 16;
                item.useAnimation = 16;

                break;

            case ItemID.CrystalStorm:
                item.damage = 37;

                break;

            case ItemID.FalconBlade:
                item.damage = 28;

                break;

            case ItemID.NightsEdge:
                item.damage = 44;
                item.scale *= 1.1f;

                break;

            case ItemID.CobaltShield:
                item.damage = 43;

                break;

            case ItemID.IceBlade:
                item.damage = 23;
                item.shootSpeed = 19.5f;

                break;

            case ItemID.IceBoomerang:
                item.damage = 25;
                item.shootSpeed = 16;

                break;

            case ItemID.BeeKeeper:
                item.damage = 28;

                break;

            case ItemID.HellwingBow:
                item.damage = 24;

                break;

            case ItemID.PhoenixBlaster:
                item.damage = 27;

                break;

            case ItemID.Sandgun:
                item.useTime = 14;
                item.useAnimation = 14;

                break;

            case ItemID.Xenopopper:
                item.damage = 53;

                break;

            case ItemID.FrostDaggerfish:
                item.damage = 22;

                break;

            case ItemID.BoneJavelin:
                item.damage = 30;

                break;

            case ItemID.BoneDagger:
                item.damage = 20;

                break;

            case ItemID.SnowballCannon:
                item.damage = 14;

                break;

            case ItemID.StarCannon:
                item.damage = 58;

                break;

            case ItemID.RubyStaff:
                item.damage = 23;

                break;

            case ItemID.DiamondStaff:
                item.damage = 25;

                break;

            case ItemID.AmberStaff:
                item.damage = 28;

                break;

            case ItemID.ThunderStaff:
                item.damage = 20;
                item.mana = 4;

                break;


            case ItemID.WeatherPain:
                item.damage = 43;

                break;

            case ItemID.MagicalHarp:
                item.damage = 66;

                break;

            case ItemID.WaspGun:
                item.damage = 51;

                break;

            case ItemID.LeafBlower:
                item.damage = 55;

                break;

            case ItemID.MagnetSphere:
                item.damage = 79;

                break;

            case ItemID.SpectreStaff:
                item.damage = 102;

                break;

            case ItemID.FlyingKnife:
                item.damage = 34;

                break;

            case ItemID.DD2SquireBetsySword:
                item.damage = 1;
                item.shootSpeed = 30;
                item.useTime = 35;
                item.useAnimation = 35;

                break;

            case ItemID.ProximityMineLauncher:
                item.damage = 1;
                item.shootSpeed = 30;
                item.useTime = 35;
                item.useAnimation = 35;

                break;

            case ItemID.HeatRay:
                item.damage = 60;

                break;

            case ItemID.ChargedBlasterCannon:
                item.damage = 1;
                item.shootSpeed = 30;
                item.useTime = 35;
                item.useAnimation = 35;

                break;

            case ItemID.ThunderSpear:
                item.damage = 24;

                break;

            case ItemID.Katana:
                item.damage = 26;

                break;

            case ItemID.FlamingMace:
                item.damage = 12;

                break;

            case ItemID.JungleYoyo:
                item.damage = 24;

                break;

            case ItemID.IceSickle:
                item.damage = 49;

                break;

            case ItemID.CobaltNaginata:
                item.useTime = 8;
                item.useAnimation = 8;
                item.damage = 49;

                break;

            case ItemID.MythrilHalberd:
                item.damage = 65;
                item.useTime = 18;
                item.useAnimation = 18;

                break;

            case ItemID.AdamantiteGlaive:
                item.damage = 80;
                item.useTime = 16;
                item.useAnimation = 16;

                break;

            case ItemID.PalladiumPike:
                item.damage = 50;
                item.useTime = 20;
                item.useAnimation = 20;

                break;

            case ItemID.OrichalcumHalberd:
                item.damage = 60;
                item.useTime = 14;
                item.useAnimation = 14;

                break;

            case ItemID.TitaniumTrident:
                item.damage = 70;
                item.useTime = 12;
                item.useAnimation = 12;

                break;

            case ItemID.Gungnir:
                item.damage = 91;
                item.useTime = 8;
                item.useAnimation = 8;

                break;

            case ItemID.DaoofPow:
                item.shootSpeed = 34;
                item.damage = 63;

                break;

            case ItemID.BlueMoon:
                item.shootSpeed = 24;

                break;

            case ItemID.Sunfury:
                item.damage = 36;

                break;

            case ItemID.FormatC:
                item.damage = 46;

                break;

            case ItemID.ZapinatorGray:
                item.damage = 61;
                item.mana = 23;

                break;

            case ItemID.SkyFracture:
                item.damage = 50;

                break;

            case ItemID.BeeGun:
                item.damage = 19;

                break;

            case ItemID.CrystalVileShard:
                item.damage = 36;

                break;

            case ItemID.SoulDrain:
                item.damage = 5;

                break;

            case ItemID.BluePhaseblade:
                item.damage = 30;

                break;

            case ItemID.GreenPhaseblade:
                item.damage = 32;

                break;

            case ItemID.OrangePhaseblade:
                item.damage = 34;
                item.useTime = 16;
                item.useAnimation = 16;

                break;

            case ItemID.RedPhaseblade:
                item.damage = 34;
                item.useTime = 16;
                item.useAnimation = 16;

                break;

            case ItemID.WhitePhaseblade:
                item.damage = 36;
                item.useTime = 14;
                item.useAnimation = 14;

                break;

            case ItemID.YellowPhaseblade:
                item.damage = 28;

                break;

            case ItemID.BluePhasesaber:
                item.damage = 50;

                break;

            case ItemID.GreenPhasesaber:
                item.damage = 54;

                break;

            case ItemID.OrangePhasesaber:
                item.damage = 64;
                item.useTime = 23;
                item.useAnimation = 23;

                break;

            case ItemID.RedPhasesaber:
                item.damage = 58;
                item.useTime = 14;
                item.useAnimation = 14;

                break;

            case ItemID.WhitePhasesaber:
                item.damage = 60;
                item.useTime = 13;
                item.useAnimation = 13;

                break;

            case ItemID.YellowPhasesaber:
                item.damage = 46;

                break;

            case ItemID.Gatligator:
                item.useTime = 4;
                item.useAnimation = 4;

                break;

            case ItemID.TacticalShotgun:
                item.damage = 67;

                break;

            case ItemID.Flamethrower:
                item.damage = 49;

                break;

            case ItemID.SuperStarCannon:
                item.damage = 96;

                break;

            case ItemID.FlowerPow:
                item.damage = 100;

                break;

            case ItemID.DarkLance:
                item.damage = 38;
                item.useTime = 15;

                break;

            case ItemID.BladeofGrass:
                item.damage = 27;

                break;

            case ItemID.Flamelash:
                item.damage = 30;
                item.mana = 32;

                break;

            case ItemID.Gladius:
                item.damage = 22;
                item.useTime = 6;
                item.useAnimation = 18;

                break;

            case ItemID.HellfireArrow:
                item.damage = 12;

                break;

            case ItemID.LightsBane:
                item.damage = 20;
                item.scale *= 1.1f;

                break;

            case ItemID.AntlionClaw:
                item.damage = 18;

                break;

            case ItemID.Rally:
                item.damage = 17;

                break;

            case ItemID.TentacleSpike:
                item.damage = 23;
                item.useTime = 20;
                item.useAnimation = 20;

                break;

            case ItemID.BoneWhip:
                item.damage = 26;
                item.useTime = 32;
                item.useAnimation = 32;

                break;

            case ItemID.Starfury:
                item.damage = 19;

                break;

            case ItemID.FireWhip:
                item.damage = 34;
                item.useTime = 38;
                item.useAnimation = 38;

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

            case ItemID.BloodButcherer:
                item.damage = 23;

                break;

            case ItemID.MagicMissile:
                item.damage = 27;

                break;

            case ItemID.EnchantedBoomerang:
                item.damage = 21;

                break;

            case ItemID.Code1:
                item.damage = 23;

                break;

            case ItemID.DartPistol:
                item.damage = 34;

                break;

            case ItemID.Swordfish:
                item.damage = 26;

                break;

            case ItemID.Bananarang:
                item.damage = 58;
                item.useTime = 11;
                item.useAnimation = 11;
                item.stack = 1;

                break;

            case ItemID.ObsidianSwordfish:
                item.damage = 81;

                break;

            case ItemID.ThornWhip:
                item.damage = 27;

                break;

            case ItemID.SlapHand:
                item.damage = 43;

                break;

            case ItemID.LightDisc:
                item.damage = 84;
                item.useTime = 12;
                item.useAnimation = 12;

                break;

            case ItemID.KOCannon:
                item.damage = 51;

                break;

            case ItemID.ChlorophyteSaber:
                item.damage = 86;
                item.shootSpeed = 14;

                break;

            case ItemID.Chik:
                item.damage = 56;

                break;

            case ItemID.ChlorophytePartisan:
                item.damage = 61;
                item.useTime = 14;
                item.useAnimation = 14;

                break;

            case ItemID.CombatWrench:
                item.damage = 32;
                item.shootSpeed = 23;

                break;

            case ItemID.LucyTheAxe:
                item.damage = 38;
                item.scale *= 1.2f;

                break;

            case ItemID.Toxikarp:
                item.damage = 51;

                break;

            case ItemID.EnchantedSword:
                item.shootSpeed = 19.5f;

                break;

            case ItemID.FruitcakeChakram:
                item.damage = 21;
                item.shootSpeed = 13;

                break;

            case ItemID.BookofSkulls:
                item.damage = 46;
                item.mana = 40;
                item.shootSpeed = 5;

                break;

            case ItemID.WaterBolt:
                item.mana = 8;

                break;

            case ItemID.DemonBow:
                item.damage = 18;

                break;

            case ItemID.CorruptYoyo:
                item.damage = 19;

                break;

            case ItemID.CrimsonYoyo:
                item.damage = 20;

                break;

            case ItemID.PoisonedKnife:
                item.damage = 17;

                break;

            case ItemID.MagicDagger:
                item.damage = 49;

                break;

            case ItemID.MeteorStaff:
                item.damage = 62;
                item.mana = 7;

                break;

            case ItemID.ShadowFlameHexDoll:
                item.damage = 73;
                item.mana = 4;

                break;
        }
    }
}