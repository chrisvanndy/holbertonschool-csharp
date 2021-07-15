using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int math = 0;
        int index = 0;

        foreach (int number in myLList)
        {
            
            if (index == myLList.Count) 
            {   
                break;
            }
            else
            {
                math += number;
                index++;
            }
        }
        return math;
    }
}

