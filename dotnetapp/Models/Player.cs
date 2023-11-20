﻿namespace dotnetapp.Models
{
     public class Player
    {
        public int Id{get;set;}

        [Required(ErrorMessage="Name is required.")]
        [MaxLength(17)]
        public string Name{get;set;}
        public string Category{get;set;}

        [ForeignKey("Team")]
        public int TeamId{get;set;}

        [Range(1,int.MaxValue,ErrorMessage="Bidding amount must be greater than 0.")]
        public decimal BiddingAmount{get;set;}

        public Team ? team{get;set;}        

    }
}
