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
    public class AddressController : ControllerBase
    {
        private readonly AdventureWorksContext _dbcontext;
        public AddressController(AdventureWorksContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public Address Get(int id)
        {
            Address a = _dbcontext.Address.Find(id);
            return a;
        }
    }
}
