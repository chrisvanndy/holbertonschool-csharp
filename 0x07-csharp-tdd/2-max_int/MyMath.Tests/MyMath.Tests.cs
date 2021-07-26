using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
       
        [Test]
        ///<summary>Max_Positive_ints checks for maximum int among all positive ints<summary>
        public void Max_Positive_ints()
        {
             var myList = new List<int>{1, 2, 3, 4, 5};
             Assert.AreEqual(5, Operations.Max(myList));
        }
    }
}