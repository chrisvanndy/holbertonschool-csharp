using System;


///<summary>Class Queue manually defines a class which expectes a Type.</summary>
class Queue<T>
{
    ///<summary>CheckType returns the type of the queue object its called on.</summary>
    ///<return>The CheckType method returns the type of Queue object its operating on.</return>
    public Type CheckType()
    {
        return typeof(T);
    }
}

