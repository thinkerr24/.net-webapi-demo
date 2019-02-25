using MyWebAPI.Bussiness.Services;
using MyWebAPIDemo.DAL.Model;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        private static PersonService service = new PersonService();
        static void Main(string[] args)
        {
            List<Person> list = service.getAllPerson();
            foreach(Person p in list)
            {
                Console.WriteLine("Person name:{0}, Person age:{1}", p.name, p.age);
            }
        }
    }
}
