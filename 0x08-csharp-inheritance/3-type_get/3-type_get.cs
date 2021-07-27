using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Obj Class</summary>
class Obj
{
    ///<summary>Prints info about myObj to console.</summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] prop = myObj.GetType().GetProperties();
        MethodInfo[] meth = myObj.GetType().GetMethods();
    

        Console.WriteLine(myObj.GetType().Name + " Properties:");
        foreach (PropertyInfo p in prop)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(myObj.GetType().Name + " Methods:");
        foreach (MethodInfo m in meth)
        {
            Console.WriteLine(m.Name);
        }
    }
}

