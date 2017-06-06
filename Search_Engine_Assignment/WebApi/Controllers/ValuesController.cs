using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<People> Get()
        {
			List<People> people = new List<People>() {
				new People{Name = "Nikolas", Surname = "Skurupatis"},
				new People{Name = "Nemanja", Surname = "Tomic"},
				new People{Name = "Svetlana", Surname = "Letic"}
			};

			//foreach (var item in people) {
			//	Console.WriteLine(item);
			//}
			return people.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
