using System;
using System.Collections.Generic;


class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int count = 0;
        
        foreach (int number in myLList)
        {
            if (count == n)
            {   
                return number;
            }
            count++;
        }
        return 0;
    }
}

