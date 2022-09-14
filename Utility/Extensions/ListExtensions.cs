using System.Collections.Generic;

namespace EmpranionBR.Utility.Extensions;

public static class ListExtensions
{
    public static bool TryInsert<T>(this List<T> list, int index, T element) {
        if (index != -1) {
            list.Insert(index, element);
        }

        return index != -1;
    }
}