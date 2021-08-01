using System;


    class VectorMath
    {
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] product = new double[] {-1};

            if (vector.Length < 2 || vector.Length > 3)
            {
                return product;
            }

            if (vector.Length == 2)
            {
                product = new double[2] (scalar * vector[0], scalar * vector[1])
            }
            
            return vector;
        }

        static void Main(string[] args)
        {
            double[] vectorEx = new double[]{2, -3, 0};
            double scalarEx = 2;

            Console.WriteLine("{0}", string.Join(", ", VectorMath.Multiply(vectorEx, scalarEx)));

        }
    }
