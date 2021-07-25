using MyMath;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        ///<summary> Tests Operations.Add() two positive integers</summary>
        public void Add_Values_SumCorrect()
        {
            Operations adding = new Operations();

            var result = Operations.Add(1, 3);

            Assert.AreEqual(result, 4);
            
        }

        [Test]
        ///<summary> Tests Operations.Add() doesn't reutrn null.</summary>
        public void Add_Values_isNotNull()
        {
            Operations adding = new Operations();

            var result = Operations.Add(2, 8);

            Assert.IsNotNull(result);
        }

        [Test]
        ///<summary> Tests Operations.Add() one negative parameter.</summary>
        public void Add_Values_oneNegative()
        {
            Assert.AreEqual(8, Operations.Add(10, -2));
        }

        [Test]
        ///<summary> Tests Operations.Add() two negative parameter</summary>
        public void Add_Values_twoNegative()
        {
            Assert.AreEqual(-5, Operations.Add(-3, -2));
        }

    }
}