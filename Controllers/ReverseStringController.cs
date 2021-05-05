using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string ReverseString(string str)
        {
            if (str == null)
            {
                str = "this string has been reversed racecar";
            }
            return string.Concat(str.ToArray().Reverse());
        }
    }
}