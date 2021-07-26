using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
       
        [Test]
        ///<summary>Max_Positive_ints checks for maximum int at end of list<summary>
        public void Max_Positive_end()
        {
             var myList = new List<int>{1, 2, 3, 4, 5};
             Assert.AreEqual(5, Operations.Max(myList));
        }
        [Test]
        ///<summary>Max_Positive_end checks for maximum int at begginning of list<summary>
        public void Max_Positive_begin()
        {
            var myList = new List<int>{5, 4, 3, 2, 1};
            Assert.AreEqual(5, Operations.Max(myList));
        }
         [Test]
        ///<summary>Max_Positive_end checks for maximum int in middle of list<summary>
        public void Max_Positive_middle()
        {
            var myList = new List<int>{1, 2, 5, 3, 4};
            Assert.AreEqual(5, Operations.Max(myList));
        }
        [Test]
        ///<summary>Max_Positive_end checks for maximum int with negatives in list<summary>
        public void Max_Positive_negative()
        {
            var myList = new List<int>{1, -2, 5, -3, 4};
            Assert.AreEqual(5, Operations.Max(myList));
        }
        [Test]
        ///<summary>Max_Positive_end checks for maximum int an empty list<summary>
        public void Max_Positive_empty()
        {
            var myList = new List<int>{};
            Assert.AreEqual(0, Operations.Max(myList));
        }
    }
}