using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Basic
{
    public class FPA
    {
        // No take params and return int
        Func<int> noInParam = () => 3;

        // Take int and return int
        Func<int, int> square = (x) => x + x;

        // Take int, int and return int
        Func<int, int, int> rectangle = (x, y) => x * y;

        // Take int and return string
        Func<int, string> str = (x) => x.ToString();

        // Take int , int and return void
        Action<int, int> act = (x, y) => Console.WriteLine(x + y);


        // Take 1 params(required) and return bool
        Predicate<int> isOdd = (x) => x % 2 == 0;

    }
}
