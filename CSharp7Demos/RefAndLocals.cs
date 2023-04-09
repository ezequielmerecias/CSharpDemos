using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class RefAndLocals
    {
        public void Start()
        {
            int[] numbers = { 1, 2, 3 };
            ref int refToSecond = ref numbers[1];
            var valueOfSecond = refToSecond;



            refToSecond = 123;
            Console.WriteLine(String.Join(",", numbers));

            Array.Resize(ref numbers, 1);
            Console.WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            refToSecond = 321;
            Console.WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            //numbers.SetValue(321, 1);

            var numberList = new List<int> { 1, 2, 3 };
            //ref int second = ref numberList[1];

            int[] moreNumbers = { 10, 20, 30 };
            ref int refToThirty = ref Find(moreNumbers, 30);
            refToThirty = 1000;

            Find(moreNumbers, 10) = 555;


            Console.WriteLine(string.Join(",", moreNumbers));


            int a = 1, b = 2;
            int minValue = Min(ref a, ref b);

            static ref int Min(ref int x, ref int y)
            {
                //return x < y ? (ref x) : (ref y);
                if (x < y) return ref x;
                return ref y;
            }

            static ref int Find(int[] numbers, int value)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == value)
                        return ref numbers[i];
                }

                throw new ArgumentException("meh");
            }
            
        }
    }
}
