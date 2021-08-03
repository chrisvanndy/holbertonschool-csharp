using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rMatrix;
        double[,] wrongSize = new double[,]{{-1}};
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int[] vector = new int[2];

        if (row != 2 && col != 2)
        {
            return wrongSize;
        }
        
        for (int i = 0; i < row; i++)
        {
            vector[0] = (matrix[i][0] * Math.Cos(angle)) - (matrix[i][1] * Math.Sin(angle));
            vector[1] = (matrix[i][0] * Math.Sin(angle)) + (matrix[i][1] * Math.Cos(angle));
            rMatrix[i] = vector;
        }

        return rMatrix;
    }

    static void Main(string[] args)
    {
        double[,] matrix = new double[,]{{1, 2}, {3, 4}};
        double angle = -1.57;

        Console.WriteLine("[{0}]", string.Join(", ", MatrixMath.Rotate2D(matrix, angle)));
    }
}

