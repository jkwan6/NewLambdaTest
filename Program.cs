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
            int x = 20;
            int y;


            Func<int,int> numbers = x => x * x;

            y = numbers(x);

            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
