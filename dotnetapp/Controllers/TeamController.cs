using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public TeamController(ApplicationDbContext _context)
        {
            context=_context;
        }

        [HttpGet]
        [Route("GetAllPlayers")]
        public 

    }
}