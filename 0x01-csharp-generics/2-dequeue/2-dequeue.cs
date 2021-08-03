using System;


///<summary>Class Queue manually defines a class which expectes a Type.</summary>
class Queue<T>
{
    ///<summary>CheckType returns the type of the queue object its called on.</summary>
    ///<return>The CheckType method returns the type of Queue object its operating on.</return>

    ///<summary>Define properties of Node Class.</summary>
    public class Node
    {
        public T value;
        public Node next = null;
        
        //Constructor for value
        public Node(T val)
        {
            value = val;
        }
        
    }
    // define Node object head
    public Node head;
    //define Node object tail
    public Node tail;
    // int variable count
    int count;

    ///<summary>Enqueue adds node to the tail of a list</summary>
    ///<param name="value">The value may be of any type and is set to the.</param>
    public void Enqueue(T value)
    {
        //Create an object instance of "Node"
        Node addEnd = new Node(value);

        //If head is null (list is empty)
        if (head == null)
        {
            //set head equal to node being added (head is tail)
            head = addEnd;
            tail = addEnd;
        }
        //If head is not null, and tail is defined...
        else
        {
            //set tail.next equal to the Node ojbect 
            tail.next = addEnd;
            //set the newly created node to tail
            tail = addEnd;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        tail.value = head.value;
        head = head.next;
        count--;
        
        return tail.value;

    }
    ///<summary>Count returns the number of nodes in a linked list</summary>
    public int Count()
    {
        return count;
    }

    public Type CheckType()
    {
        return typeof(T);
    }
}