using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext _context)
        {
            context = _context;
        }

       

        [HttpPost]
        [Route("PostTeam")]
        public IActionResult PostTeam()
        {
            return Ok();            
        }
        [HttpGet]
        [Route("GetTeams")]
        public IActionResult GetTeams()
        {
            var data=context.Teams.ToList();
            return Ok(data);
        }
        [HttpPut]
        [Route("PutTeam")]
        public IActioResult PutTeam(int teamid,Team t)
        {
            return ok();
        }


        [HttpGet]
        [Route("GetPlayers")]
        public IActionResult GetPlayers()
        {
            var data=context.Players.ToList();
            return Ok(data);
        }
        [HttpPut]
        public IActionResult PutPlayer(int playerid,Player p)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeletePlayer(int id)
        {
            var data=context.Players.Find(id);
            if(data==null)
            {
                return NotFound();
            }
            context.Remove(data);
            context.SaveChanges();
            return Ok();
        }
        
    }
}