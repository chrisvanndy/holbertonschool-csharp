using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Unit Tests for Str class.</summary>
    public class Tests
    {
        [Test]
        ///<summary>Returns index of first nonrepeating characther</summary>
        public void Returns_nonrepeat()
        {
            int index = Str.UniqueChar("Programmer");
            Assert.AreEqual(index, 0);
        }
    }
}