using System;

///<summary>Shape class defines methods to work with shapes</summary>
class Shape
{
    ///<summary>Area() defines method to return area of given shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
///<summary>Class Rectangle inherits from Shape.</summary>
class Rectangle : Shape
{
    ///<summary>Private int width</summary>
    private int width;
    ///<summary>Private int height.</summary>
    private int height;

    ///<summary>Public get/set property for Rectangle.Width</summary>
    public int Width
    {
      get
      {
          return width;
      }
      set
      {
          if (value < 0)
          {
              throw new ArgumentException("Width must be greater than or equal to 0");
          }
          width = value;
      }
    }
        ///<summary>Public get set field for Rectangle.Height</summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be greater than or equal to 0");
                }
                height = value;
            }
        }
}

