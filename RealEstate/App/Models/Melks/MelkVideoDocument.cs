using System;

namespace RealEstate.App.Models.Melks
{
    public class MelkVideoDocument
    {
        public Guid Id { get; set; }
        public int MelkId { get; set; }
        public Melk Melk { get; set; }
        public Guid DocumentId { get; set; }
        public string Extension { get; set; }
    }
}
