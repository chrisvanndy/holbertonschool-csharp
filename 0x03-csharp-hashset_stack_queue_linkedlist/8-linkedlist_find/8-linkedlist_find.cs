using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = -1;

        foreach (int node in myLList)
        {
            index += 1;
            if (node == value)
            {
                break;
            }
            else if (index == myLList.Count - 1)
            {
                return -1;
            }
        }
        return index;
    }
}

