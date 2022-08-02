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
    public class AddressTypeController : GenericApiController<AddressType, int>
    {
        public AddressTypeController(AdventureWorksContext context) : base(context)
        { }

    }
}
