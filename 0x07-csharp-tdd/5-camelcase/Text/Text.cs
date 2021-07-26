using System;

namespace Text
{
    ///<summary>Str Class contains methods that perform functions on strings.</summary>
    public class Str
    {
        ///<summary>CamelCase returns word cound in string.</summary>
        ///<param name="s">"s" is the string passed in the be analyzied.</param>
        ///<returns>The count of words in the string "s"</returns>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int i = 1;
            for (int x = 1; x < s.Length; x++)
            {
                if (s[x] >= 65 && s[x] <= 90)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
