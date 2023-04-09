using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class Deconstruct
    {
        public void Exercise()
        {
            var mypoint = new Point();
            var (x, y) = mypoint;
        }
    }

    public class Point
    {
        public int X, Y;
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }


}
