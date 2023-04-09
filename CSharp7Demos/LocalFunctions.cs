using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class LocalFunctions
    {
        public void Exercise()
        {
            static Tuple<double, double> SolveQuadratic(double a,
    double b, double c)
            {

                var CalculateDiscriminant = new Func<double, double, double, double>(
                    (aa, bb, cc) => bb * bb - 4 * aa * cc);

                var disc = CalculateDiscriminant(a, b, c);
                var rootDisc = Math.Sqrt(disc);
                return Tuple.Create(
                    (-b - rootDisc) / (2 * a),
                    (-b + rootDisc) / (2 * a));

                //double CalculateDiscriminant() => b * b - 4 * a * c;
            }
        }
    }
}
