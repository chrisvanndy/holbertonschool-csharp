using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        //Returns a new list of all division results
        List<int> newList = new List<int>();
            
        // loop through to index passed through from main
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                //try to access each list at index given
                newList.Add(list1[i] / list2[i]);
            }

            catch (DivideByZeroException)
            {
                //elements can’t be divided, division result equals 0
                Console.WriteLine("Cannot divide by zero");
                newList.Add(0);
                
            }

            catch (ArgumentOutOfRangeException)
            {
                //if index is out of range from list
                Console.WriteLine("Out of range");
            }
        }
      
        return newList;
    }
}

// ERROR RECIEVED -- Catch clauses cannot follow the general catch clause of a try statement.  initially tried to created two generic catch clauses with parameters built to catch 0 or out of range indexes.  This is not allowed, and catch statements if more than one, must be specified with their exception.

