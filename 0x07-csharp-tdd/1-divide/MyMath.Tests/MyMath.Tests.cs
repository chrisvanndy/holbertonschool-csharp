using NUnit.Framework;
using MyMath;
using System;
using System.Linq;

namespace MyMath.Tests
{
     [TestFixture]
    public class MatrixTests
    {
        [Test]
        ///<summary>Tests Matrix.Divid() is not null</summary>
        public void Matrix_notnull()
        {
            var newMatrix = new Random();
            var array = (from col in Enumerable.Range(0, 4)
                        select (from row in Enumerable.Range(0, 4)
                        select newMatrix.Next()).ToArray()).ToArray();

            int divided = Matrix.Divide(newMatrix, 2);

            Assert.IsNotNull(divided);
        }

        [Test]
        public void Matrix_()
        {
            
        }
    }
}