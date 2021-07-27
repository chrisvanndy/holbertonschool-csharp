using System;
using System.Collections.Generic;
using System.Reflection;

namespace _3_type_get
{
    class Obj
    {
        public static void Print(object myObj)
        {
            Type obj = myObj.GetType();
            TypeInfo t = obj.GetTypeInfo();
            IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
            IEnumerable<MethodInfo> mList = t.DeclaredMethods;

            Console.WriteLine("{0} Properties:", obj.Name);
            foreach (PropertyInfo p in pList)
            {
                Console.WriteLine("{0}", p.Name);
            }
            Console.WriteLine("{0} Methods:", obj.Name);
            foreach (MethodInfo m in mList)
            {
                Console.WriteLine("{0}", m.Name);
            }
        }
    }
}
