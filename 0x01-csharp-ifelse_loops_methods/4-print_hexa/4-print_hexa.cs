using System;

class Program
{
    static void Main(string[] args)
    {
        int hex;
        for (hex = 0; hex <= 98; hex++)
        {
            Console.Write("{0:d} = 0x{0:x}\n", hex);
        }
    }
}

