using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWorksAPIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public int Get (int id)
        {
            return id;
        }

        [HttpGet]
        public string Test(int id)
        {
            string ret = String.Empty;

            switch (id)
            {
                case 1:
                    ret = "Suckcess";
                    break;
                case 2:
                    ret = "Too";
                    break;
                case 3:
                    ret = "Tree";
                    break;
                default:
                    break;
            }

            return ret;
        }
    }
}
