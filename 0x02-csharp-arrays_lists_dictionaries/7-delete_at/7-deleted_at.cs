using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        myList.Remove(index + 1);
        return myList;
    }
}

