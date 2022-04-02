using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLambdaTest
{
    class LambdaTest
    {
        static void Main(string[] args)
        {
            int x = 35;
            int y;


            Func<int, int> numbers = result => x * x;

            y = numbers(0);

            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
