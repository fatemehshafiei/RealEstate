
using RealEstate.App.Models.Melks;
using System;

namespace RealEstate.App.DTos.Melks.Gardens
{
    public class UpdateGardenDto
    {
        public string Title { get; set; } 
        public string? RegistrationPlate { get; set; }
        public AddAdressDto Address { get; set; }
        public DateTime CreateDate { get; set; }
        public int Size { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? RentAmount { get; set; }
        public decimal? Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string? Detail { get; set; }
    }
}