using System;
using System.Collections.Generic;
using System.Text;

namespace TestBLL.Models
{
    public class OrderFilter
    {
        public DateTime DateTime1 { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime DateTime2 { get; set; } = DateTime.Now;
    }
}
