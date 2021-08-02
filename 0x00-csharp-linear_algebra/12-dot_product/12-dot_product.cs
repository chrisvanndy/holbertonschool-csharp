using System;

///<summary>Vector math contains functions that perform linear alebraic equations with 2D and 3D vectors.</summary>
class VectorMath
{
    ///<summary>DotProduct returns the dot product of two vectors (2D or 3D) and returns the resulting double.</summary>
    ///<param name="vector1">2D or 3D vector a</param>
    ///<param name="vector2">2D or 3D vector b</param>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dProduct = -1;

        if (vector1.Length == 2 && vector1.Length == vector2.Length)
        {
            dProduct = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
        }
        else if (vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            dProduct = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
        }
        return (dProduct);

    }
}