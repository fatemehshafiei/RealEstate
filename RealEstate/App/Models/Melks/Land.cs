namespace RealEstate.App.Models.Melks
{
    public class Land:Melk
    {
        public int OnEarth { get; set; }//برزمین
        public int? TransPassWidth { get; set; }//عرض گذر
        public Melk Melk { get; set; }
    }
}
