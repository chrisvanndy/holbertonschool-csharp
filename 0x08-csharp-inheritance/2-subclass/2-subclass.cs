using System;

///<summary>Obj Class.</summary>
class Obj
{
    ///<summary>IsOnlyASubclass returns true or false based on wether derivedType is subclass of baseType.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}

