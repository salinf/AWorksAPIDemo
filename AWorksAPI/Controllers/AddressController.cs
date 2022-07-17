using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksDataModels;
using AWorksAPIDemo.ORM;

namespace AWorksAPI.Controllers
{
    
    [ApiController]
    public class AddressController : GenericApiController<Address, int> 
    {
        //private readonly AdventureWorksContext _dbcontext;
        public AddressController(AdventureWorksContext context) : base(context)
        {}

        //[HttpGet]
        //public Address Get(int id)
        //{
        //    Address a = _dbcontext.Address.Find(id);
        //    return a;
        //}
    }
}
