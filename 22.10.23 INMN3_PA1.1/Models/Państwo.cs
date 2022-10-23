using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _22._10._23_INMN3_PA1._1.Models
{
    public class Państwo
    {
        public int Id { get; set; }
        public string? Nazwa { get; set; }

        public uint? Populacja { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Powierzchnia { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime DataZałożenia { get; set; }
        
        public string? Stolica { get; set; }

    }
}
