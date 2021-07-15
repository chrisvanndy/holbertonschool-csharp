using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)    
    {
        HashSet<int> diff1 = new HashSet<int>(list1);
        HashSet<int> diff2 = new HashSet<int>(list2);
        List<int> newList = new List<int>();

        diff1.SymmetricExceptWith(diff2);

        foreach (int number in diff1)
        {
            newList.Add(number);
            newList.Sort();
        }
        return newList;

    }
}

