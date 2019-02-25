using MyWebAPI.DAL.DAO;
using MyWebAPIDemo.DAL.Model;
using System.Collections.Generic;

namespace MyWebAPI.Bussiness.Services
{
    public class PersonService
    {
       private PersonAgent agent = new PersonAgent();
       public  List<Person> getAllPerson()
        {
            return agent.GetList();
        }
    }
}