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
        public IActionResult PostTeam(Team t)
        {
            context.Players.Add(t);
            context.SaveChanges();

            return Created("Team Added",t);            
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
            var Team
            return ok();
        }

        [HttpDelete]
        [Route("DeleteTeam")]
        public IActionResult DeleteTeam()
        {
            return Ok();
        }



        [HttpPost]
        [Route("PostPlayer")]
        public IActionResult PostPlayer(Player p)
        {
            return Ok();
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