using System;
class Program
{ 
    static void Main(string[] args)
    {
        for (int x = 0; x < 9; x++)
        {
            for (int y = (x + 1); y < 10; y++)
            {
                if (x < 8)
                {
                    Console.Write("{0}{1}, ", x, y);
                }
                else
                {
                    Console.WriteLine("{0}{1}", x, y);
                }
            }
        }
    }
}
