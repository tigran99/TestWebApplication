using System;
using System.Collections.Generic;
using System.Text;

namespace TestBLL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow; // GMT+4
        public List<Item> Items { get; set; }

        public double TotalCost()
        {
            double cost = 0;
            foreach(var item in Items)
            {
                cost += item.Price * item.Count;
            }
            return cost;
        }
    }
}
