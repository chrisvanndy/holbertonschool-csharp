using System;


class Int
{
    public static void divide(int a, int b)
    {
        int num = 0;
        try
        {
            num = (a / b);
        }
        catch
        { 
            if (b == 0)
                Console.WriteLine("Cannot divide by zero");
                    

        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, num);
        }
    }
}

