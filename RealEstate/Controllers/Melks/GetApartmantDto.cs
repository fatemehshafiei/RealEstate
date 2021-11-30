using RealEstate.App.DTos.Melks.Gardens;
using System;

namespace RealEstate.Controllers.Melks
{
    public class GetApartmantDto
    {
        public int Id { get; set; }
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
        public byte Age { get; set; }
        public byte RoomCount { get; set; }
        public byte Floor { get; set; }
        public bool? HasElevator { get; set; }
        public bool? HasLoan { get; set; }
        public bool? HasStoreRoom { get; set; }
        public bool? HasParking { get; set; }
    }
}