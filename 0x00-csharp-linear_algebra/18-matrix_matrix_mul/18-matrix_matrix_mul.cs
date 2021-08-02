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
        int colMatrix1 = matrix1.GetLength(0);
        int rowMatrix2 = matrix2.GetLength(1);
    
    if (colMatrix1 != rowMatrix2)
    {
        return cantMul;
    }

    for (int i = 0; i < colMatrix1; i++)
    {
        for (int j = 0; j < rowMatrix2; j++)
        {
            newMatrix[i,h] = 0;
            for (int k = 0; k < colMatrix1; k++)
            {
                newMatrix[i,j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
    }

}

