using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        // return a new list
        List<bool> newList = new List<bool>();
        // iterate through passed list
        foreach (int num in myList)
        {
            // add values to new list based on if
            if (num % 2 == 0)
            {
                newList.Add(true);
            }
            else
            {
                newList.Add(false);
            }
        }
        // return new list
        return newList;
    }
}

