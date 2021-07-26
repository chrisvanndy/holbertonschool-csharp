using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    ///<summary>Str Class tests input strings for various outcomes</summary>
    public class Str
    {
        ///<summary>IsPalindrome tests to see if parameter is palindrome.</summary>
        ///<param name="s">"s" is given string to be tested.</param>
        ///<returns>True if the passed string is a palendrome</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return true;
            }

            s = s.ToLower();
            string onlyChars = "";
        
            foreach (char c in s)
            {
                if (c < 97 || c > 122)
                {
                    onlyChars += c;
                }
            }

            var testPalindrom = onlyChars.ToArray();

            return testPalindrom.SequenceEqual(testPalindrom.Reverse());

        }
    }
}

  
 
