namespace RealEstate.App.Models.Melks
{
    public class ApartmentComplex : Melk
    {
        public byte Age { get; set; }
        public byte NumberOfFloors { get; set; }
        public bool? HasElevator { get; set; }
        public bool? HasLoan { get; set; }
        public bool? HasStoreRoom { get; set; }
        public bool? HasParking { get; set; }
        public Melk Melk { get; set; }
    }
}