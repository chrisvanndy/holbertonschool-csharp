using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> inBoth1 = new HashSet<int>(list1);
        HashSet<int> inBoth2 = new HashSet<int>(list2);
        List<int> newList = new List<int>();

        inBoth1.IntersectWith(inBoth2);

        foreach (int number in inBoth1)
        {
            newList.Add(number);
        }
        return newList;
    }

    
}

