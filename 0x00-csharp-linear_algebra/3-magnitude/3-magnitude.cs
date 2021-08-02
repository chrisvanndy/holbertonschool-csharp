using System;

///<summary>VectorMath contains functions to calculate the magnitue of 2D and 3D vectors.</summary>
class VectorMath
{
    ///<summary>Magnitude caclulated the lenght of a vector</summary>
    ///<param name="vector">The given coordinates of a 2D or 3C vector</param>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        double x = 0;

        foreach (double c in vector)
        {
            double sqr = 0;
            sqr = Math.Pow(c, 2);
            x += sqr;
        }

        return Math.Round(Math.Sqrt(x), 2);
    }
} 



