using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionEvents.Common.Systems;

public sealed class EmpranionRecipeSystem : ModSystem
{
    public override void AddRecipes() {
        Recipe recipe = Recipe.Create(ItemID.SwiftnessPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.RegenerationPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.IronskinPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.SpelunkerPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.NightOwlPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.WaterWalkingPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.ShinePotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.MiningPotion);
        recipe.AddIngredient(ItemID.WormholePotion, 4);
        recipe.AddTile(TileID.Bottles);
        recipe.Register();

        recipe = Recipe.Create(ItemID.LuckyHorseshoe);
        recipe.AddIngredient(ItemID.GoldBar, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
        recipe = Recipe.Create(ItemID.LuckyHorseshoe);
        recipe.AddIngredient(ItemID.PlatinumBar, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.MagicMirror);
        recipe.AddIngredient(ItemID.Glass, 15);
        recipe.AddIngredient(ItemID.RecallPotion, 5);
        recipe.AddIngredient(ItemID.SilverBar, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
        recipe = Recipe.Create(ItemID.MagicMirror);
        recipe.AddIngredient(ItemID.Glass, 15);
        recipe.AddIngredient(ItemID.RecallPotion, 5);
        recipe.AddIngredient(ItemID.TungstenBar, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.IceMirror);
        recipe.AddIngredient(ItemID.Glass, 15);
        recipe.AddIngredient(ItemID.RecallPotion, 5);
        recipe.AddIngredient(ItemID.IceBlock, 20);
        recipe.AddTile(TileID.IceMachine);
        recipe.Register();

        recipe = Recipe.Create(ItemID.CloudinaBottle);
        recipe.AddIngredient(ItemID.Cloud, 30);
        recipe.AddIngredient(ItemID.Bottle);
        recipe.AddIngredient(ItemID.Feather, 3);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.HermesBoots);
        recipe.AddIngredient(ItemID.Feather, 2);
        recipe.AddIngredient(ItemID.Silk, 12);
        recipe.AddIngredient(ItemID.GreenThread);
        recipe.AddTile(TileID.Loom);
        recipe.Register();

        recipe = Recipe.Create(ItemID.FlurryBoots);
        recipe.AddIngredient(ItemID.Feather, 2);
        recipe.AddIngredient(ItemID.Silk, 12);
        recipe.AddIngredient(ItemID.IceBlock, 60);
        recipe.AddTile(TileID.Loom);
        recipe.Register();

        recipe = Recipe.Create(ItemID.SandBoots);
        recipe.AddIngredient(ItemID.AntlionMandible, 4);
        recipe.AddIngredient(ItemID.Silk, 12);
        recipe.AddIngredient(ItemID.FossilOre, 20);
        recipe.AddTile(TileID.Loom);
        recipe.Register();

        recipe = Recipe.Create(ItemID.FeralClaws);
        recipe.AddIngredient(ItemID.JungleSpores, 15);
        recipe.AddIngredient(ItemID.ClayBlock, 20);
        recipe.AddTile(TileID.Furnaces);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BandofRegeneration);
        recipe.AddIngredient(ItemID.Ruby, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BandofStarpower);
        recipe.AddIngredient(ItemID.Sapphire, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.SkeletronHand);
        recipe.AddIngredient(ItemID.Bone, 60);
        recipe.AddTile(TileID.BoneWelder);
        recipe.Register();

        recipe = Recipe.Create(ItemID.FruitcakeChakram);
        recipe.AddRecipeGroup(RecipeGroupID.Fruit, 4);
        recipe.AddIngredient(ItemID.WoodenBoomerang);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.Cascade);
        recipe.AddIngredient(ItemID.HellstoneBar, 12);
        recipe.AddIngredient(ItemID.Bone, 20);
        recipe.AddIngredient(ItemID.WoodYoyo);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.Bananarang, 2);
        recipe.AddIngredient(ItemID.Banana, 4);
        recipe.AddIngredient(ItemID.Flamarang);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();

        recipe = Recipe.Create(ItemID.Revolver);
        recipe.AddIngredient(ItemID.FlintlockPistol, 2);
        recipe.AddTile(TileID.HeavyWorkBench);
        recipe.Register();

        recipe = Recipe.Create(ItemID.FrostStaff);
        recipe.AddIngredient(ItemID.FrostCore);
        recipe.AddIngredient(ItemID.IceBlock, 70);
        recipe.AddIngredient(ItemID.Sapphire, 5);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();

        recipe = Recipe.Create(ItemID.Blowgun);
        recipe.AddIngredient(ItemID.Blowpipe);
        recipe.AddIngredient(ItemID.IllegalGunParts);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.WoodenBoomerang);
        recipe.AddIngredient(ItemID.Wood, 16);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BookofSkulls);
        recipe.AddIngredient(ItemID.Book);
        recipe.AddIngredient(ItemID.Bone, 80);
        recipe.AddTile(TileID.BoneWelder);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BloodMoonStarter);
        recipe.AddIngredient(ItemID.Vertebrae, 6);
        recipe.AddIngredient(ItemID.Lens, 4);
        recipe.AddIngredient(ItemID.TinBar, 8);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BloodMoonStarter);
        recipe.AddIngredient(ItemID.RottenChunk, 6);
        recipe.AddIngredient(ItemID.Lens, 4);
        recipe.AddIngredient(ItemID.TinBar, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BloodMoonStarter);
        recipe.AddIngredient(ItemID.RottenChunk, 6);
        recipe.AddIngredient(ItemID.Lens, 4);
        recipe.AddIngredient(ItemID.CopperBar, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();

        recipe = Recipe.Create(ItemID.BloodMoonStarter);
        recipe.AddIngredient(ItemID.Vertebrae, 6);
        recipe.AddIngredient(ItemID.Lens, 4);
        recipe.AddIngredient(ItemID.CopperBar, 8);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}