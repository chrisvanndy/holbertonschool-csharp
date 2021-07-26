using NUnit.Framework;
using MyMath;
using System;
using System.Linq;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
       
        public static int[,] testMatrix = new int[3,3] {{2, 4, 6}, {8, 10, 12}, {14, 16, 18}};
        
        [Test]
        ///<summary>Text Divide function with dividision by "num".</summary>
        public void Matrix_Division()
        {
            int[,] solution = Matrix.Divide(testMatrix, 2);
            Assert.AreEqual(solution, new int[3,3]{{1, 2, 3,}, {4, 5, 6}, {7, 8, 9}});
        }

    }
}