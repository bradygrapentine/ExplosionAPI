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
            return string.Concat(str.Select(n => new string(n, int.Parse(n.ToString())))); // some solutions involve going from ASCII value of character to ASCII value needed to select the intAsChar the correct number of times (num - 48, gives ASCII number that corressponds to value of char)

            // var result = "";
            // for (var i = 0; i < str.Length; i++)
            // {
            //     int charAsInt = int.Parse(str[i].ToString());
            //     for (var j = 0; j < charAsInt; j++)
            //     {
            //         result += charAsInt;
            //     }
            // }
            // return result;
        }
    }
}