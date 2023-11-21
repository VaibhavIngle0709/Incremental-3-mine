using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
namespace dotnetapp.Models
{
    
  public class Team
    {
        [Key]
        public int ? TeamId{get;set;}
        public string TeamName{get;set;}
        public decimal maximumBudget{get;set;}
        public ICollection<Player> ?Players{get;set;}
    }
}
