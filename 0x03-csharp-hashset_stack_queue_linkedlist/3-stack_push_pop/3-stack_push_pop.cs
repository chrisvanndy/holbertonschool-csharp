using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        string booly;

        
        if (aStack == null || aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            foreach (string item in aStack)
            {
                count++;
            }
        }  

        Console.WriteLine("Number of items: {0}", count);

        Console.WriteLine("Top item: {0}", aStack.Peek());

        if (aStack.Contains(search))
        {
            booly = "True";
            while (aStack.Count > 0)
            {
                aStack.Pop();
                if (aStack.Pop() == search)
                {
                    break;
                }
               
            }
        }
        else
        {
            booly = "False";
        }
        Console.WriteLine("Stack contains {0}: {1}", search, booly);

        aStack.Push(newItem);

        return aStack;


    }
}
