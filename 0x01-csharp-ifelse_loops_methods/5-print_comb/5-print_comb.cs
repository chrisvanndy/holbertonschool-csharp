using System;

class Program
{
    static void Main(string[] args)
    {
	int num;
	for (num = 0; num <= 99; num++)
        {
            if (num <= 98)
            {
                Console.Write("{0:d2}, ", num);
            }
            else
            {
                Console.Write("{0:d}", num);
            }
        }
    }
}
