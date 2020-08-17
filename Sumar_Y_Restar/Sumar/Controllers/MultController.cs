using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultController : ControllerBase
    {
        [HttpGet]
        [Route("Product")]
        public int Product(int a, int b)
        {
            return a * b;
        }
        [HttpPost]
        [Route("Product")]
        public int Product2(int a, int b)
        {
            return a * b;
        }
    }
}
