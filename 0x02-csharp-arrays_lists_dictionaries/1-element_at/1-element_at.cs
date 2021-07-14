using System;


class Array
{
       public static int elementAt(int[] array, int index)
       {
           // index cannot be length (0 index) or negative
           if (array.Length <= index || index < 0)
           {
               Console.WriteLine("Index out of range");
               return -1;
           }
           // simple return array at given index
           return array[index];
            
       }    
}

