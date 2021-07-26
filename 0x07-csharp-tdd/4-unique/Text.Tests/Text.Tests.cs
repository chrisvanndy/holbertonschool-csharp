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

        [Test]
        ///<summary>Returns index of first nonrepeating characther last</summary>
        public void Returns_nonrepeat_last()
        {
            int index = Str.UniqueChar("Ppeeddr");
            Assert.AreEqual(index, 0);
        }

        [Test]
        ///<summary>Returns index of first nonrepeating characther middle</summary>
        public void Returns_nonrepeat_middle()
        {
            int index = Str.UniqueChar("Ppeedlltt");
            Assert.AreEqual(index, 0);
        }

        [Test]
        ///<summary>Returns index of first nonrepeating characther (none)</summary>
        public void Returns_nonrepeat_none()
        {
            int index = Str.UniqueChar("ppssttllmmooaa");
            Assert.AreEqual(index, -1);
        }

        [Test]
        ///<summary>Returns index of first nonrepeating characther (empty)</summary>
        public void Returns_nonrepeat_empty()
        {
            int index = Str.UniqueChar("");
            Assert.AreEqual(index, -1);
        }
    }
}