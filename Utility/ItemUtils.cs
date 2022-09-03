using Terraria;
using Terraria.ID;

namespace EmpranionBR.Utility;

public static class ItemUtils
{
    public static void CleanItemInventory(Item[] inventory) {
        for (int i = 0; i < inventory.Length; i++) {
            Item item = inventory[i];

            if (item == null || item.type == ItemID.None) {
                continue;
            }
            
            item.TurnToAir();
        }
    }
}