using System;

///<summary>Vector math contains functions that perform linear alebraic equations with 2D and 3D vectors.</summary>
class VectorMath
{
    ///<summary>Add adds two vectors (2D or 3D) and returns the resulting vector.<summary>
    ///<param name="vector1">2D or 3D vector a</param>
    ///<param name="vector2">2D or 3D vector b</param>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vectorArray = new double[] {-1};

        if (vector1.Length == 2 && vector1.Length == vector2.Length)
        {
            vectorArray = new double[2] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
        }
        else if (vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            vectorArray = new double[3] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
        }
        return (vectorArray);

    }
}

   /* static void Main(string[] args)
    {
        double[] array1 = new double[] {1, 2, 4};
        double[] array2 = new double[] {1, 2, 4};

        Console.WriteLine("[{0}]", string.Join(", ", VectorMath.Add(array1, array2)));

    }
} */

