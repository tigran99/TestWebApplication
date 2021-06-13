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
        }
    }
}
