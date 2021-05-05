using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/*
Create a controller for ReverseString
Create a new Controller called ReverseStringController
This will have one HttpGet method
The method will accept a string either as a URL parameter or a query parameter. Your choice.
This endpoint method will reverse the string passed to it, manipulate it according to the kata Reverse String and return the result
Have your code return the string
*/
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