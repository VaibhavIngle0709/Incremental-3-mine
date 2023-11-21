namespace dotnetapp.Models
{
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
     public class Player
    {
        public int Id{get;set;}

        [Required(ErrorMessage="Name is required.")]
        [MaxLength(17)]
        public string Name{get;set;}
      

      [ForeignKey("Team")]
        public int TeamId{get;set;}

        public int Age{get;set;}

        [Range(1,int.MaxValue,ErrorMessage="Bidding amount must be greater than 0.")]
        public decimal BiddingPrice{get;set;}
        public string Category{get;set;}

        public Team ? team{get;set;}        

    }
}
