using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        ///<summary>Tests palindrom with no spaces, special characters, caps</summary>
        public void Palindrome_lettersonly()
        {
            var palindrome =  Str.IsPalindrome("level");
            Assert.IsTrue(palindrome);
        }
    }
}