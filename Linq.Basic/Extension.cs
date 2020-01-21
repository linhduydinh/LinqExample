using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Basic
{
    public static class Extension
    {
        public static int Count<T>(this IEnumerable<T> items)
        {
            int total = 0;
            foreach (var item in items)
            {
                total += 1;
            }
            return total;
        }
    }
}
