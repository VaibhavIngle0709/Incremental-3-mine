using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {

        public IActionResult Login()
        {
            return Ok();
        }   

        public IActionResult Register()
        {
            return Ok();
        }
    }
}