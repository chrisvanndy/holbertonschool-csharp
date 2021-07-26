using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Unit tests for Str class</summary>
    public class TestsStr
    {
        [Test]
        ///<summary>Wordcount returns the number of words in string</summary>
        public void Wordcount()
        {
            Assert.AreEqual(5, Str.CamelCase("is A Major Lasor Show"));
        }

         [Test]
        ///<summary>Wordcount returns the number of words in string (1)</summary>
        public void Wordcount_one()
        {
            Assert.AreEqual(1, Str.CamelCase("is"));
        }

         [Test]
        ///<summary>Wordcount returns the number of words in string</summary>
        public void Wordcount_one_cap()
        {
            Assert.AreEqual(1, Str.CamelCase("Major"));
        }

         [Test]
        ///<summary>Wordcount returns the number of words in string</summary>
        public void Wordcount_all_caps()
        {
            Assert.AreEqual(5, Str.CamelCase("Is A Major Lasor Show"));
        }

         [Test]
        ///<summary>Wordcount returns the number of words in string</summary>
        public void Wordcount_empty_string()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }
    }
}