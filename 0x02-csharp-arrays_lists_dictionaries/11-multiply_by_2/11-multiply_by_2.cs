using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // new dictionary = myDict
        Dictionary<string, int> newest = new Dictionary<string, int>(myDict);

        // iterating through passed dict
        foreach (string key in myDict.Keys)
        {
            // for each key in myDict newest key = *2
            newest[key] = (newest[key] * 2);
        }

        return newest;
    }
}

