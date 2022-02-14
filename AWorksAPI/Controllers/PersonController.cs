using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksDataModels;
using AWorksAPIDemo.ORM;

namespace AWorksAPIDemo.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly AdventureWorksContext _dbcontext;
        public PersonController(AdventureWorksContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public Person Get (int id)
        {
            Person p = _dbcontext.Person.Find(id);
            
            return p;
        }

        [HttpDelete]
        public int Delete(Person person)
        {
            var p = _dbcontext.Person.Remove(person);
            int retval =_dbcontext.SaveChanges();

            return retval;
        }

        [HttpPost]
        public Person Post (Person person)
        {
            var p = _dbcontext.Person.Add(person);
            _dbcontext.SaveChanges();

            return p.Entity;
        }

        [HttpPut]
        public Person Put(Person person)
        {
            var p = _dbcontext.Person.Update(person);
            _dbcontext.SaveChanges();

            return p.Entity;
        }

    }
}
