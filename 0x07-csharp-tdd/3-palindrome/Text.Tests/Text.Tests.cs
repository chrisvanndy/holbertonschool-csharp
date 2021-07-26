using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Tests for the Str Class</summary>
    public class Tests
    {
        [Test]
        ///<summary>Tests palindrom with no spaces, special characters, caps</summary>
        public void Palindrome_ispalindrome()
        {
            var palindrome =  Str.IsPalindrome("level");
            Assert.IsTrue(palindrome);
        }
        [Test]
        ///<summary>Tests palindrom with no spaces, special characters, caps</summary>
        public void Palindrome_isNotpalindrome()
        {
            var palindrome =  Str.IsPalindrome("steak");
            Assert.IsFalse(palindrome);
        }
        [Test]
        ///<summary>Tests palindrom with spaces, special characters, caps</summary>
        public void Palindrome_ispalindrome_specialChar()
        {
            var palindrome =  Str.IsPalindrome("Po-op po-oP");
            Assert.IsTrue(palindrome);
        }
        [Test]
        ///<summary>Tests palindrom with no spaces, special characters, caps</summary>
        public void Palindrome_isNotpalindrome_specialChar()
        {
            var palindrome =  Str.IsPalindrome("My name is Vanndy");
            Assert.IsFalse(palindrome);
        }

        [Test]
        ///<summary>Tests the world Holberton</summary>
        public void Palindrome_Holberton()
        {
            var palindrome = Str.IsPalindrome("Holberton");
            Assert.IsFalse(palindrome);
        }
        
        [Test]
        ///<summary>Tests the phrase: "A man, a plan, a canal: Panama."</summary>
        public void Palindrome_given()
        {
            var palindrome = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.IsTrue(palindrome);
        }
    }
}