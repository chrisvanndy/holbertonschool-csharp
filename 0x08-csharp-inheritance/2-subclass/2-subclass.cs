using System;

namespace _2_subclass
{
    class Obj
    {
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
}
