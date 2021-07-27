using System;

namespace _1_instance
{
    class Obj
    {
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
}
