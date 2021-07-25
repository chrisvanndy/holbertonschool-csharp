using System;
using System.Linq;

namespace MyMath
{
    ///<summary>Operations defines functions in the Operations class</summary>
    public class Operations
    {
        ///<sumary>Max method returns max int in a given list</summary>
        public static int Max(List<int> nums)
        {
            if (nums.GetLength() == 0)
            {
                return 0;
            }
            int max = nums.Max();
            return max;
        }
    }
}
