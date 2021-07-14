using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
         // Step 2: get keys and sort them.
        var list = myDict.Keys.ToList();
        list.Sort();

        // Step 3: loop through keys.
        foreach (var key in list)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}

