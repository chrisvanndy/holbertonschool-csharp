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
        ///<summary>Test Divide function with dividision by "num".</summary>
        public void Matrix_Division()
        {
            int[,] solution = Matrix.Divide(testMatrix, 2);
            Assert.AreEqual(solution, new int[3,3]{{1, 2, 3,}, {4, 5, 6}, {7, 8, 9}});
        }

        [Test]
        ///<summary>Test Divide function with division by 0.</summary>
        public void Matrix_Divide_0()
        {
            try
            {
                int[,] soulution = Matrix.Divide(testMatrix, 0);
            }
            catch(Exception e)
            {
                Assert.AreEqual(e, "Num cannot be 0");
            }
        }
        [Test]
        ///<summary>Test Divide function with null matrix.</summary>
        public void Matrix_null()
        {
            int[,] solution = Matrix.Divide(null, 2);
            Assert.AreEqual(solution, null);
        }

    }
}