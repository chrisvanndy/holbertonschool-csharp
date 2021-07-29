using System;

///<summary>VectorMath contains functions to calculate the magnitue of 2D and 3D vectors.</summary>
class VectorMath
{
    ///<summary>Magnitude caclulated the lenght of a vector</summary>
    ///<param name="vector">The given coordinates of a 2D or 3C vector</param>
    public static double Magnitude(double[] vector)
    {
        double x = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        foreach (double c in vector)
        {
            double sqr = 0;
            sqr = Math.Pow(c, 2);
            x += sqr;
        }

        return Math.Round(Math.Sqrt(x), 2);
    }
} 
    /* static void Main(string[] args)
    {
        double[] array = {3};

        Console.WriteLine("The magnitude of the given vector array is : {0}", VectorMath.Magnitude(array));
    } 
} */



