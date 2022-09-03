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
    public Item[] OldBank { get; private set; }
    public Item[] OldBank2 { get; private set; }
    public Item[] OldBank3 { get; private set; }
    public Item[] OldBank4 { get; private set; }

    public void CleanItems() {
        OldDye = Player.dye;
        OldMiscDyes = Player.miscDyes;
        OldMiscEquips = Player.miscEquips;
        OldArmor = Player.armor;
        OldInventory = Player.inventory;
        OldBank = Player.bank.item;
        OldBank2 = Player.bank2.item;
        OldBank3 = Player.bank3.item;
        OldBank4 = Player.bank4.item;
        
        ItemUtils.CleanItemInventory(Player.dye);
        ItemUtils.CleanItemInventory(Player.miscDyes);
        ItemUtils.CleanItemInventory(Player.miscEquips);
        ItemUtils.CleanItemInventory(Player.armor);
        ItemUtils.CleanItemInventory(Player.inventory);
        ItemUtils.CleanItemInventory(Player.bank.item);
        ItemUtils.CleanItemInventory(Player.bank2.item);
        ItemUtils.CleanItemInventory(Player.bank3.item);
        ItemUtils.CleanItemInventory(Player.bank4.item);
    }

    public void ReturnItems() {
        Player.dye = OldDye;
        Player.miscDyes = OldMiscDyes;
        Player.miscEquips = OldMiscEquips;
        Player.armor = OldArmor;
        Player.inventory = OldArmor;
        Player.bank.item = OldBank;
        Player.bank2.item = OldBank2;
        Player.bank3.item = OldBank3;
        Player.bank4.item = OldBank4;
    }
}