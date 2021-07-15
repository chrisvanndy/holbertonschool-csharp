using System;
using System.Collections.Generic;
using System.Text;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newnode = myLList.AddFirst(n);
        return newnode;
    }
}
