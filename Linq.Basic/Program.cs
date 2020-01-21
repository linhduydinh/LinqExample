using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new decimal[] {1, 2, 3, 4, 5 };

            var count = Extension.Count(items);

            Action<int, int> abc = (x, y) => Console.WriteLine(x + y);

            Func<int, int, int> func = (x, y) => {
                Console.WriteLine(x * y);
                return x * y;
            };

            Predicate<int> chan = (x) => x % 2 == 0;


            Console.WriteLine(chan(5));

            //Console.WriteLine(count);

        }
    }
}
