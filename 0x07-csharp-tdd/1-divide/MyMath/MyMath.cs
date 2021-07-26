using System;
using System.Linq;

namespace MyMath
{
    ///<summary>MyMath contains class Matrix, and methods to perform arithmetic on the Matrix class.</summary>
    public class Matrix
    {
        ///<summary>Divides given matrix by given integer.</summary>
        ///<param name="matrix">Given array for division.</param>
        ///<param name="num">Given integer to divide array.</param>
        ///<returns>New "matrix" divided by "num".</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.Error.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
            {
                return null;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] /= num;
                }
            }
            return matrix;
        }
    }
}
