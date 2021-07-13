using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char alpha;
            for (alpha = 'a'; alpha <= 'z'; alpha++)
            {
                if (alpha == 'e'|| alpha == 'q')
                    continue;
                else
                    Console.Write("{0}", alpha);
            }
        }
    }
}
