using System;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>IsInstanceOfArry returns true or false based on wether obj is type(array).</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

