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
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Explosion(string str) // Why can't static be here??
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                int charAsInt = int.Parse(str[i].ToString());
                for (var j = 0; j < charAsInt; j++)
                {
                    result += charAsInt;
                }
            }
            return result;
        }
    }
}