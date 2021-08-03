using System;

///<summary>MatrixMath performs operations on matrices</summary>
class MatrixMath
{
    ///<summary>Transpose flip flops the colums and rows in a matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        double[,] newMatrix = new double[column, row];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                newMatrix[j, i] = matrix[i, j];
            }
        }
        
        return newMatrix;
    }
}

