using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBLL.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public Car Car { get; set; }
        public List<Car> Cars { get; set; }
    }

    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
