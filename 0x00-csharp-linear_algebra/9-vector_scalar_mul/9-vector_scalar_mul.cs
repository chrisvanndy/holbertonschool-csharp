using System;

    ///<summary>VectorMath defines methods to work with 2D and 3D vectors</summary>
    class VectorMath
    {
        ///<summary>Multiply returns the vector multiplications of given "vector" by give "scalar".</summary>
        ///<param name="vector">passed vector can be 2D or 3D vector.</param>
        ///<param name="scalar">passed scalar can be positive or negative double.</param>
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] product = new double[] {-1};

            if (vector.Length < 2 || vector.Length > 3)
            {
                return product;
            }

            if (vector.Length == 2)
            {
                product = new double[2] {scalar * vector[0], scalar * vector[1]};
            }
            
            if (vector.Length ==3)
            {
                product = new double[3] {scalar * vector[0], scalar * vector[1], scalar * vector[2]};
            }

            return product;
        }

    }
