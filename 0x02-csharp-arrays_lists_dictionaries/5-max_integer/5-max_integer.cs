using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {

        if (myList.Count == 0 || myList == null)
        {
            Console.WriteLine("List is Empty");
            return -1;
        }
        // sorting list sorts items in ascending order
        myList.Sort();
        // return sorted list (count - 1)
        return (myList[myList.Count -1]);
    
    }    
}

