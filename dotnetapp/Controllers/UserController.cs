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
        [Route("Login")]
         public IActionResult Login(User u)
        {
            return Ok();
        }   

        [HttpPost]
        public IActionResult Register(User u)
        {

            return Ok();
        }
 

       
        
    }
}