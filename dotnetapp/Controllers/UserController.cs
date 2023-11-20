using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UserController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        [Route("GetAllPlayers")]
        public IActionResult GetAllPlayers()
        {
            var data=context.Players.ToList();
            return data;
        }

        [HttpGet]
        [Route("GetSpecificPlayer")]
        public IActionResult GetSpecificPlayer(int Id)
        {
            var data=context.Players.Find(Id);
            return data;
        }

        
    }
}