using System;

class Program
{
    static void Main(string[] args)
    {
	Random rndm = new Random();
	int number = rndm.Next(-1000, 1000);
	if (number % 10 > 5)
    { 
	    Console.WriteLine("The last digit of {0:d} is {1:d} and is greater than 5", number, (number % 10));
	}
    else if (number % 10 == 0)
    {
	    Console.WriteLine("The last digit of {0:d} is {1:d} and is 0", number, (number % 10));
    }
    else
    {
        Console.WriteLine("The last digit of {0:d} is {1:d} and is less than 6 and not 0", number, (number % 10));
	}
    }
}
