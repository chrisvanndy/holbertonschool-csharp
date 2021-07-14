using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // if a key already exsists update it, else create it.
        myDict[key] = value;
     
        return myDict;
    }
     
}

