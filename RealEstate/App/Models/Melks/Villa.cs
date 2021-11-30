namespace RealEstate.App.Models.Melks
{
    public class Villa:Melk
    {
        public byte Age { get; set; }
        public byte RoomCount { get; set; }
        public short BuildingSize { get; set; }
        public int Length { get; set; }
        public int? TransPassWidth { get; set; }//عرص گذر
        public Melk Melk { get; set; }
    }
}
