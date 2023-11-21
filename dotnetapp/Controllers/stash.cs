// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using dotnetapp.Models;

// namespace dotnetapp.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class TeamController : ControllerBase
//     {
//         private readonly ApplicationDbContext context;
//         public TeamController(ApplicationDbContext _context)
//         {
//             context=_context;
//         }

//         [HttpGet]
//         [Route("GetAllPlayers")]
//         public IActionResult GetAllPlayers()
//         {
//             var data=context.Teams.ToList();
//             return Ok(data);
//         }


//         [HttpGet]
//         public IActionResult GetPlayersOfSpecificTeam(int teamid)
//         {
//             List<Player> data=context.Players.ToList();
//             List<Player> p=new List<Player>();

//             for(int i=0;i<data.Count;i++)
//             {
//                 if(data[i].TeamId==teamid)
//                 {
//                   //  p.Add(data[i]);
//                 }
//             }
//             return Ok(p);
//         }

// // 
//         [HttpPost]
//         [Route("CreateTeam")]
//         public IActionResult PostTeam(Team t)
//         {
//             context.Teams.Add(t);
//             context.SaveChanges();
//             return Created("Added Record",t);
//         }


//     }
// }