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

       ///TEAMS CRUD/////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Route("PostTeam")]
        public IActionResult PostTeam(Team t)
        {
            context.Teams.Add(t);
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
        public IActionResult PutTeam(int teamid,Team t)
        {
            var teamcheckidvalid=context.Teams.Find(teamid);
            if(teamcheckidvalid==null)
            {
                return BadRequest("Team ID Not Found");
            }
            var tobj=context.Teams.Find(teamid);
            tobj.TeamName=t.TeamName;
            tobj.maximumBudget=t.maximumBudget;
            context.SaveChanges();
            return Ok("Team Deleted");
        }

        [HttpDelete]
        [Route("DeleteTeam")]
        public IActionResult DeleteTeam(int teamid)
        {
            var data=context.Teams.Find(teamid);
            if(data==null)
            {
                return BadRequest("Team Id Not Found");
            }
            context.Teams.Remove(data);
            context.SaveChanges();
            return Ok("Team Deleted");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/////////////////////PLAYER CRUD////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Route("PostPlayer")]
        public IActionResult PostPlayer(Player p)
        {
            context.Players.Add(p);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("GetPlayerById")]
        public IActionResult GetPlayerBYId(int playerid)
        {
            var data=context.Players.Find(playerid);
            if(data==null)
            {   
                return BadRequest("Player ID Does Not Exist");
            }

            return Ok(data);
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
             var teamcheckidvalid=context.Teams.Find(teamid);
            if(teamcheckidvalid==null)
            {
                return BadRequest("Team ID Not Found");
            }
            var tobj=context.Teams.Find(teamid);
            tobj.TeamName=t.TeamName;
            tobj.maximumBudget=t.maximumBudget;
            context.SaveChanges();
            return Ok("Team Deleted");
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