using MyWebAPIDemo.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyWebAPI.DAL.DAO
{
    public class PersonAgent
    {

        public List<Person> GetList()
        {
            using (var context = new FirstDBEntities())
            {
                return context.Person.ToList();
            }
        }
    }
}
