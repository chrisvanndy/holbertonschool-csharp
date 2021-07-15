using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)         
    {
        string booly;

        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue == null || aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First itemn: {0}", aQueue.Peek());
        }

        aQueue.Enqueue(newItem);

        if (aQueue.Contains(search))
        {
            booly = "True";
            while (aQueue.Count > 0)
            {
                string val = aQueue.Dequeue();
                if (val == search)
                {
                    break;
                }
            }
        }
        else
        {
            booly = "False";
        }

        Console.WriteLine("Queue contains {0}: {1}", search, booly);

        return aQueue;        
    }
}

