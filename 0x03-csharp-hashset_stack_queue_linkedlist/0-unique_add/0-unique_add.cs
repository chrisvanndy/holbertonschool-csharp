using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> math = new HashSet<int>(myList);

        foreach (int number in math)
        {
            sum += number;
        }
        return sum;
    }
}
    /* public static int Sum(List<int> myList)
    {
        List<int> math = new List<int>();
        int sum = 0;
        foreach (int number in myList)
        {
            if(!math.Contains(number))
            {
                math.Add(number);
            }
        }
        
        for (int i = 0; i < math.Count; i++)
        {
            sum += math[i];
        }
        return sum;
    }
} */

