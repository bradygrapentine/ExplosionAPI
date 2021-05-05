using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
/*
Create a controller for explosion
Create a new Controller called ExplosionController
This will have one HttpGet method
The method will accept a string either as a URL parameter or a query parameter. Your choice.
This endpoint method will take the string passed to it, manipulate it according to the kata Digits Explosion and return the result
Have your code return the string
*/
namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Mumbling(string str)
        {
            var result = "";
            for (var i = 0; i < str.Length; i++)
            {
                for (var j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        result += char.ToUpper(str[i]);
                    }
                    else
                    {
                        result += char.ToLower(str[i]);
                    }
                }
                if (i != str.Length - 1)
                {
                    result += "-";
                }
            }
            return result;
        }
    }
}