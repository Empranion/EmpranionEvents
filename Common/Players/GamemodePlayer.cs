using EmpranionBR.Utility;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EmpranionBR.Common.Players;

public sealed class GamemodePlayer : ModPlayer
{
    public Item[] OldDye { get; private set; }
    public Item[] OldMiscDyes { get; private set; }
    public Item[] OldMiscEquips { get; private set; }
    public Item[] OldArmor { get; private set; }
    public Item[] OldInventory { get; private set; }
    
    public void CleanItems() {
        OldDye = Player.dye;
        OldMiscDyes = Player.miscDyes;
        OldMiscEquips = Player.miscEquips;
        OldArmor = Player.armor;
        OldInventory = Player.inventory;
        
        ItemUtils.CleanItemArray(Player.dye);
        ItemUtils.CleanItemArray(Player.miscDyes);
        ItemUtils.CleanItemArray(Player.miscEquips);
        ItemUtils.CleanItemArray(Player.armor);
        ItemUtils.CleanItemArray(Player.inventory);
    }

    public void ReturnItems() {
        Player.dye = OldDye;
        Player.miscDyes = OldMiscDyes;
        Player.miscEquips = OldMiscEquips;
        Player.armor = OldArmor;
        Player.inventory = OldArmor;
    }
}