using System;

///<summary>MatrixMath performs operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Method that shears a 2D matrix by factor and direction</summary>
    ///<param name="matrix">Parameter matrix is the passed matrix.</param>
    ///<param name="direction">Parameter 'direction' indicates to shear matrix in the X or Y direction</param>
    ///<param name="factor">Parameter 'factor' indicates a the shear factor by which to shear the matrix.</param>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        double[,] wrongSize = new double[,]{{-1}};
        double[,] shear = new double[2,2] {{1,0}, {0,1}};
        double[,] newMatrix = new double[2,2];

        if (row != 2 || col != 2 && direction != 'x' || direction != 'y')
        {
            return wrongSize;
        }

        if (direction == 'x')
        {
            shear[1, 0] = factor;
        }

        if (direction == 'y')
        {
            shear[0, 1] = factor;
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    newMatrix[i, j] += matrix[i ,k] * shear[k, j];
                }
            }
        }

        return newMatrix;
    }
}
