using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class Shape
    {

    }

    public class Rectangle : Shape
    {
        public int Width, Height;
    }

    public class Circle : Shape
    {

    }

    static class Demo
    {
        public static void DisplayShape(Shape shape)
        {
            if(shape is Rectangle r)
            {
                var rc = (Rectangle)shape;
            }

            switch (shape)
            {
                case Circle c: break;
                case Rectangle sq when (sq.Height == sq.Width): break;
            }
            
        }
    }
    public class PatternMatching
    {
        public void Exercise()
        {

        }
    }
}
