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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Mumbling(string str)
        {
            return string.Join("-", str.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            // var result = "";
            // for (var i = 0; i < str.Length; i++)
            // {
            //     for (var j = 0; j < i + 1; j++)
            //     {
            //         if (j == 0)
            //         {
            //             result += char.ToUpper(str[i]);
            //         }
            //         else
            //         {
            //             result += char.ToLower(str[i]);
            //         }
            //     }
            //     if (i != str.Length - 1)
            //     {
            //         result += "-";
            //     }
            // }
            // return result;
        }
    }
}