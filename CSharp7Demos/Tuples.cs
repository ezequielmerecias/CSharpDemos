using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class Tuples
    {
        static Tuple<double, double> SumandProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }
        public void Exercise()
        {

            var sp = SumandProduct(2, 5);
            Console.WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");

            var sp2 = NewSumAndProduct(2, 5);
            Console.WriteLine($"sum = {sp2.sum}, product = {sp2.product}");
            Console.WriteLine(sp2.GetType());

            ValueTuple<double, double> vt = sp2;

            (double ss, double pp) = NewSumAndProduct(2, 3);
            var (sum, product) = NewSumAndProduct(1, 2);

            double s, p;
            (s, p) = NewSumAndProduct(1, 2);

            var me = (name: "Dmitri", age: 21);

            var snp = new Func<double, double, (double, double)>((a, b) => (a + b, a * b));

        }
    }
}
