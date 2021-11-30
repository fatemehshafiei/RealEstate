namespace RealEstate.App.Models.Melks
{
    public class  ParticipationConstruction:Melk
    {
        public byte NumberOfFloors { get; set; }
        public int? TransPassWidth { get; set; }
        public int LengthOfLength { get; set; }
        public Melk Melk { get; set; }
    }
}
