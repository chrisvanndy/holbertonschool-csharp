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
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return true;
            }

            var characters = s.ToArray();

            var reversed = characters.Reverse();

            return characters.SequenceEqual(reversed);
        }
    }
}

  
 
