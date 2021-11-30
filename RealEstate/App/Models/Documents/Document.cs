using System;

namespace RealEstate.App.Models.Inducs
{
    public class Document
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreationDate { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
    }
  
}
