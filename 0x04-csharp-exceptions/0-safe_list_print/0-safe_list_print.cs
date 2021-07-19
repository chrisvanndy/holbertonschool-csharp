using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        foreach (int item in myList)
        try
        {
            if (count < n)
            {
                Console.WriteLine(item);
                count++;
            }
        }
        catch
        {
            return count;
        }

        return count;
    }
}
// Trying with for loop
  /* {
        int i;
        for (i = 0; i < n; i++)
        try
        {
                Console.WriteLine("{0}", myList[i]);
        }
        catch
        {
            return i;
        }
        return i; */
    

