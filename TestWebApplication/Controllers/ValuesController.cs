using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestBLL;
using TestBLL.Models;
using ls= TestWebApplication.Helpers.ListGenerator;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Value> values =
new List<Value>
{
               new Value { Id = 1, Name = "Mukuch", Surname = "Poxosyan"},
               new Value { Id = 2, Name = "Mkrtich", Surname = "Vardanyan"}
};
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Value> Get([FromQuery] Filter filter)
        {
            return values.Where(x => x.Name.Contains(filter.nameLike) || x.Surname.Contains(filter.surNameLike));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        //[Route("getBysocialcard/{id}")]
        public string Get(int id)
        {
            return values.Find(x => x.Id == id).Name;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async System.Threading.Tasks.Task PostAsync(/*[FromBody] Value value*/)
        {
            LinkedList<int> item = new LinkedList<int>();
            item.AddLast(1);
            item.AddLast(2);
            string serializedObject = JsonConvert.SerializeObject(item);


            Request.EnableBuffering();

            Request.Body.Position = 0;

            string rawRequestBody = await new StreamReader(Request.Body).ReadToEndAsync();
            var value = JsonConvert.DeserializeObject<Value>(rawRequestBody);


            values.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Value person)
        {
            var index = values.FindIndex(x => x.Id == id);
            values[index] = person;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            values.RemoveAll(x => x.Id == id);
        }
    }
}
