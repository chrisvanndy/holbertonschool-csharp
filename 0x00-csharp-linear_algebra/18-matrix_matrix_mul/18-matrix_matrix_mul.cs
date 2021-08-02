using System;
///<summary>MatrixMath contains functions that performat arithmetic operations on 2D and 3D matrices.</summary>
class MatrixMath
{
    ///<summary>Multipy performs matrix multiplication on two matrix (2D or 3D).</summary>
    ///<param name="matrix1">passed parameter matrix1 can be 2D or 3D matrix where colums equal rows of matrix2.</param>
    ///<param name="matrix2">passed parameter matrix2 can be 2D or 3D matrix where rows equal columns of matrix1.</param>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] cantMul = new double[,]{{-1}};
        double[,] newMatrix;
        int row = matrix1.GetLength(0);
        int col = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);
    
    if (col != row2)
    {
        return cantMul;
    }

    // initialize newMatrix with the correct w/h from passed param
    newMatrix = new double [col, row2];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row2; j++)
        {
            newMatrix[i,j] = 0;

            for (int k = 0; k < col; k++)
            {
                newMatrix[i,j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
    }

}

