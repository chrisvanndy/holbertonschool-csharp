using System;
using System.Linq;

namespace MyMath
{
    ///<summary>The Matrix class define methods and attributeds</summary>
    public class Matrix
    {
        ///<summary>Divides given matrix by given integer<summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            else if (matrix == null)
            {
                return null;
            }
            else
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i,j] /= num;
                    }
                }
                return matrix;
            }
        }
    }
}
