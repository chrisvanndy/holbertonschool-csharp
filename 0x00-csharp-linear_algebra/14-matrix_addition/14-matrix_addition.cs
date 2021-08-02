using System;

///<summary>MatrixMath contains functions that performat arithmetic operations on 2D and 3D matrices.</summary>
class MatrixMath
{
    ///<summary>Add performs matrix addition on 2 matrix (2D or 3D) of the same size.</summary>
    ///<param name="matrix1">passed parameter matrix1 can be 2D or 3D matrix of == length to matrix2.</param>
    ///<param name="matrix2">passed parameter matrix2 can be 2D or 3D matrix of == length to matrix1.</param>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // define the new array to return with arithmetic operations performed
        double[,] sumMatrix;
        // define 2D/3D array with -1 value as follows
        double[,] jaggedArr = new double[,] {{-1}};
        int row = matrix1.GetLength(0);
        int col = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);

        if ((row == 2 && col == 2) && row == row2)
        {
            sumMatrix = new double[2, 2];
        }
        else if ((row == 3 && col == 3) && row == row2)
        {
            sumMatrix = new double[3, 3];
        }
        else
        {
            return jaggedArr;
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return sumMatrix;

    }
}

