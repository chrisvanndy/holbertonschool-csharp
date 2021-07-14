using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        // defining a lis must be have (), {}, []
        var items = new List<int> {};
        for (int i = 0; i < size; i++)
        {
            // add items to a list in this way
            items.Add(i);
            // print index value
            Console.Write(items[i]);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        return items;
        


    }
}

