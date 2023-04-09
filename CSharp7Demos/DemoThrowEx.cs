using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class Demo2
    {
        public string Name { get; set; }
        public Demo2(string name)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        }

        int GetValue(int n)
        {
            return n > 0 ? n + 1 : throw new Exception();
        }

        public void Execute()
        {
            int v = -1;

            try
            {
                var d = new Demo2("");
                v = d.GetValue(-1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(v);
            }
        }
    }
}
