using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int hex;
            for (hex = 0; hex <= 98; hex++)
            {
                Console.WriteLine("{0} = 0x{0:X2}", hex);
            }
	}
    }
}
