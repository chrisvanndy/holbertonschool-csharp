using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {

        Console.WriteLine("Number of items: {0}", aStack.Count);

        Console.WriteLine("Top item: {0}", aStack.Peek());

         Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));

        if (aStack.Contains(search))
        {
            while (aStack.Count > 0)
            {
                string val = aStack.Pop();
                if (val == search)
                {
                    break;
                }
               
            }
        }

        aStack.Push(newItem);

        return aStack;


    }
}
