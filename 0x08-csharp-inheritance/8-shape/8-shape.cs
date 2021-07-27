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
        ///<summary>new overides BaseClass Area function.</summary>
        public new int Area()
        {
            return height * width;
        }

        ///<summary>overide method ToString() defines string for Rectangle class</summary>
        public override string ToString()
        {
            return "[Rectangle] " + width + " / " + height;
        }
}

///<summary>Class Square inherits from sublcass Rectangle</summary>
class Square : Rectangle
{
    ///<summary>Private int size defined for Square class</summary>
    private int size;

    ///<summary>Public field Size sets value for size.</summary>
    public int Size 
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;
        }
    }
    ///<summary>override string to return info about Square</summary>
    public override string ToString()
    {
        return "[Square] " + size + " / " + size;
    }

}
