using System;
///<summary>MatrixMath contains functions that performat arithmetic operations on 2D and 3D matrices.</summary>
class MatrixMath
{
    ///<summary>MultiplyScalar performs matrix multiplication on a matrix (2D or 3D).</summary>
    ///<param name="matrix1">passed parameter matrix1 can be 2D or 3D matrix of == length to matrix2.</param>
    ///<param name="scalar">passed parameter scalar is a double by which to multiply members of the matrix.</param>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] notOK = new double[,] {{-1}};
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row < 1 || col < 2)
        {
            return notOK;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = matrix[i,j] * scalar;
            }
        }
        return matrix;

    }
}

