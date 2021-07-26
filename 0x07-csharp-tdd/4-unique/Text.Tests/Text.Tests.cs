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
           Assert.AreEqual(0, Str.UniqueChar("Programmer"));
        }

        [Test]
        ///<summary>Returns index of first nonrepeating characther last</summary>
        public void Returns_nonrepeat_last()
        {
            Assert.AreEqual(4, Str.UniqueChar("jujus"));
        }

        [Test]
        ///<summary>Returns index of first nonrepeating characther middle</summary>
        public void Returns_nonrepeat_middle()
        {
            Assert.AreEqual(2, Str.UniqueChar("level"));
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