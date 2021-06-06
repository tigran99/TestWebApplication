using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBLL.Models;

namespace TestWebApplication1.Extensions
{
    public static class FilterExtension
    {
        static int counter = 0;
        public static void Print(this Filter filter, string a)
        {
            Console.WriteLine(filter.nameLike + " " + filter.surNameLike + " " +a);
            string
        }

        public static int Compare(this string a, String? strA, String? strB, CultureInfo? culture, CompareOptions options)
        {

        }
    }
}
