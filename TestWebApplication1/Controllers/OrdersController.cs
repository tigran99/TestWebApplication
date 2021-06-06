using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TestBLL.Models;
using TestWebApplication1.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public static List<Order> ordersList = new List<Order>
        {
            new Order 
            {
                Id = 1,
                Items = new List<Item> 
                {
                    new Item 
                    {
                        Name = "Book",
                        Price = 10,
                        Count = 3,
                        Description = "Good book"
                    },
                    new Item
                    {
                        Name = "Laptop",
                        Price = 1000,
                        Count = 1,
                        Description = "Dell Laptop"
                    }
                } 
            },
                        new Order
            {
                Id = 2,
                DateTime = DateTime.Now,
                Items = new List<Item>
                {
                    new Item
                    {
                        Name = "Book",
                        Price = 10,
                        Count = 3,
                        Description = "Good book"
                    },
                    new Item
                    {
                        Name = "Laptop",
                        Price = 1000,
                        Count = 1,
                        Description = "Dell Laptop"
                    }
                }
            }
        };
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return ordersList.Find(x => x.Id == id);
        }

        [HttpGet()]
        [Route("GetByFilter")]
        public IEnumerable<Order> Get([FromQuery] OrderFilter filter)
        {
            return ordersList.Where(x => x.DateTime > filter.DateTime1
            && x.DateTime < filter.DateTime2);
        }

        [HttpGet()]
        [Route("GetByFilter1")]
        public IEnumerable<Order> Get1([FromQuery] Filter filter)
        {
            filter.nameLike = "asa";
            filter.surNameLike = "asasa";
            FilterExtension.Print(filter, "asasa");
            return ordersList;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            ordersList.Add(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpPut]
        [Route("addItem")]
        public void AddItemToList([FromQuery] int id, [FromBody] Item item)
        {
            Order order = ordersList.Find(x => x.Id == id);
            order.Items.Add(item);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
