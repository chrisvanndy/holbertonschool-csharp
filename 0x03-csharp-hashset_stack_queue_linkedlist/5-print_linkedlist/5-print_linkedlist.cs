using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            myLList.AddLast(i);
            Console.WriteLine(i);
        }

        return myLList;
    }
}

        