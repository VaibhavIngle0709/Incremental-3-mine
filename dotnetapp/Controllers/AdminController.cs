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
            var temcheckidvalid=context.Teams.Find(teamid);
            if(teamcheckidvalid==null)
            {
                return BadRequest("Team ID Not Found");
            }
            var tobj=context.Teams.Find(teamid);
            tobj.TeamName=t.TeamName;
            tobj.maximumBudget=t.maximumBudget;
            context.SaveChanges();
            return ok("Team Deleted");
        }

        [HttpDelete]
        [Route("DeleteTeam")]
        public IActionResult DeleteTeam(int teamid)
        {
            var data=context.Teams.Find(teamid);
            if(data==null)
            {
                return BadRequest();
            }
            context.Teams.Remove(data);
            context.SaveChanges();
            return Ok("Team Deleted");
        }



        [HttpPost]
        [Route("PostPlayer")]
        public IActionResult PostPlayer(Player p)
        {
            context.Players.Add(p);
            context.SaveChanges();
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
                return NotFound("Player Id Not Found");
            }
            context.Remove(data);
            context.SaveChanges();
            return Ok();
        }
        
    }
}