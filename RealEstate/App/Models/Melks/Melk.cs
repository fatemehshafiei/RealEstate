using System;
using System.Collections.Generic;

namespace RealEstate.App.Models.Melks
{
    public class Melk
    {
        public Melk()
        {
            Videos = new HashSet<MelkVideoDocument>();
            Images = new HashSet<MelkImageDocument>();
            IsActive = true;
            Address = new Address();
        }
        public int Id { get; set; }
        public string Title { get; set; } 
        public string? RegistrationPlate { get; set; }
        public Address Address { get; set; }
        public DateTime CreateDate { get; set; }
        public int Size { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? RentAmount { get; set; }
        public decimal? Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string? Detail { get; set; }
        public HashSet<MelkVideoDocument> Videos { get; set; }
        public HashSet<MelkImageDocument> Images { get; set; }

    }
    public class Address
    {
        public string Title { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

}
