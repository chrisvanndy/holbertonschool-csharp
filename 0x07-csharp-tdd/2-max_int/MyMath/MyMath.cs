using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Operations defines functions in the Operations class</summary>
    public class Operations
    {
        ///<summary>Max method returns max int in a given list</summary>
        ///<param name="nums">List nums to be analyized for max member</param>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
    
           int maximum = nums[0];
           foreach (int numbers in nums)
           {
               if (numbers > maximum)
               {
                   maximum = numbers;
               }
           }
           return maximum;
        }
    }
}
