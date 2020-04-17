using Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C.Controllers
{
    public class PeopleController : ApiController
    {
        // Initializing a list that is binding to a Person Model
        List<Person> people = new List<Person>();
        // Here I'm making an dictionary array object 
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Peter", Lastname = "Tran", Id = 1 });
            people.Add(new Person { FirstName = "Michael", Lastname = "Murray", Id = 2 });
            people.Add(new Person { FirstName = "Michelle", Lastname = "Phan", Id = 3 });

        }

        // Now we want to make a new method called GetFirstNames()
        // Here we will make a loop and append the first name to a list
        // We want a new route here for a new endpoint that is different from https://localhost:44352/api/people
        // It is now https://localhost:44352/api/people/getfirstnames

        [Route("api/people/getfirstnames")]
        [HttpGet, HttpPost]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }


        // Now we have a route with a custom item, this is how we can grab that LastName
        [Route("api/people/getbylastnames/{LastName}")]
        [HttpGet]
        public Person getbylastnames(string LastName)
        {
            return people.Where(x => x.Lastname == LastName).FirstOrDefault();
        }




        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return people;
        }

        // GET: api/People/{id}
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            // people.Remove(Person.ReferenceEquals(people.Id, id);
        }
    }
}
