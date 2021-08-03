using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rMatrix = new double[2,2];
        double[,] wrongSize = new double[,]{{-1}};
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        

        if (row != col)
        {
            return wrongSize;
        }
        
        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    rMatrix[i,j] = Math.Round(rMatrix[i, j] + (matrix[i, k] * rotate[k, j]), 2);
                }
            }
        }

        return rMatrix;
    }
}

