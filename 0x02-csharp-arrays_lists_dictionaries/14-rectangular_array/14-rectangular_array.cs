using System;


class Program
{
    static void Main(string[] args)
    {
        CreateGrid();

        Console.ReadKey ();
    }

    public static void CreateGrid()
    {
        int width = 5;
        int height = 5;

        int [,] grid = new int[width, height];
        grid[2,2] = 1;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Console.Write(grid[x,y]);
                if( y < height - 1)
                {
                    Console.Write(" ");
                }
            
            }
        Console.WriteLine();
        }
    }
}

