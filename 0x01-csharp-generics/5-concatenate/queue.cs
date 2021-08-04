using System;


///<summary>Class Queue manually defines a class which expects a Type.</summary>
class Queue<T>
{
    ///<summary>CheckType returns the type of the queue object it is called on.</summary>
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
    ///<param name="value">The value may be of any type and is set to the value of the Node object</param>
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
            //?? tail was = head, pointer to next then set to head??
            tail.next = addEnd;
            //set the newly created node to tail
            //** this concept is stiff fuzzy address at PLD
            tail = addEnd;
        }
        count++;
    }

    ///<summary>Dequeue returns the first value in a Queue and removes the Node</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        //** this concept is still fuzzy discuss at PLD why set to tail?
        //** ?? this is because tail is a traversing / temp pointer??
        tail.value = head.value;
        head = head.next;
        count--;
        
        return tail.value;

    }

    ///<summary>Peek returns the value at the head of the Queue without augmenting the Queueu</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    ///<summary>Print prints each item in Queue on a new line.</summary>
    public void Print()
    {
         if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }

        tail = head;
        while (tail != null)
        {
            Console.WriteLine(tail.value);
            tail = tail.next;
        }

    }
    ///<summary>Concatenate concatenates Queue objects of type Char or Str only.</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        else if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        else 
        {
            int spacer = 0;
            string toCat = "";
            // set tail node to head of list
            tail = head;

            if (typeof(T) == typeof(char))
            {
                // as long as node is not null, concat .value to new string var
                while (tail != null)
                {
                    toCat += tail.value;
                    tail = tail.next;
                }
            }
            
            else if (typeof(T) == typeof(string))
            {
                while (tail != null)
                {
                    if (spacer != 0)
                    {
                        toCat += " ";
                    }
                    toCat += tail.value;
                    tail = tail.next;
                    spacer++;
                }
            }
            return toCat;
        }
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