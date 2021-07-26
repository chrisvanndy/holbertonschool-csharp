using System;

namespace Text
{
    ///<summary>Str class defines methods to test incomding string</summary>
    public class Str
    {
        ///<summary>Unique Char returns index of first non-repeating character</summary>
        ///<param name="s">"s" is the given string to analyze for non-repeating chars</param>
        ///<returns>Returns the index of the first non-repeating character</returns>
        public static int UniqueChar(string s)
        {  
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (s.Split(c).Length - 1 == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
