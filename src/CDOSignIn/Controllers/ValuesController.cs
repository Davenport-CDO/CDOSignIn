using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CDOSignIn.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> GetNames()
        {
            return StaticData.Names;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string signIn)
        {
        }
    }
}
