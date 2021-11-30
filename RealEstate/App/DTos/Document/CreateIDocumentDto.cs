using System.ComponentModel.DataAnnotations;

namespace RealEstate.App.DTos.Indus
{
    public class CreateDocumentDto
    {
        [Required]
        public byte[] Data { get; set; }
        [Required]
        [MaxLength(10)]
        public string Extension { get; set; }
    }
}
