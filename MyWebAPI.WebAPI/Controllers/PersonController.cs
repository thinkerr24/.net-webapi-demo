using MyWebAPI.Bussiness.Services;
using MyWebAPIDemo.DAL.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;

namespace MyWebAPI.WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        private PersonService service = new PersonService();
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            List<Person> list = service.getAllPerson();
            return JsonConvert.SerializeObject(list);
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
