using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class OutVariables
    {
        public void Exercise()
        {
            DateTime dt;
            if (DateTime.TryParse("01/01/2017", out dt))
            {
                Console.WriteLine(dt);
            }

            if (DateTime.TryParse("02/02/2016", out var dt2))
            {
                Console.WriteLine(dt2);
            }

            int.TryParse("abc", out var i);
            Console.WriteLine(i);

        }
    }
}
