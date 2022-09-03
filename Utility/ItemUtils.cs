using Terraria;
using Terraria.ID;

namespace EmpranionBR.Utility;

public static class ItemUtils
{
    public static void CleanItemArray(Item[] array) {
        for (int i = 0; i < array.Length; i++) {
            Item item = array[i];

            if (item == null || item.type == ItemID.None) {
                continue;
            }
            
            item.TurnToAir();
        }
    }
}