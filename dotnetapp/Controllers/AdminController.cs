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

        [HttpGet]
        [Route("GetPlayers")]
        public IActionResult GetPlayers()
        {
            var data=context.Players.ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetTeams")]
        public IActionResult GetTeams()
        {
            var data=context.Teams.ToList();
            return Ok(data);
        }
        [HttpPut]
        public IActionResult PutPlayer(int teamid,Player p)
        {
            context.Players.Add(p);
            return Created("Added Record",p);
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