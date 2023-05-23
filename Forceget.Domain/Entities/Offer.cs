using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Offer")]
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        Mode Mode { get; set; }
        MovementType Movement { get; set; }
        Incoterm Incoterm { get; set; }
        PackageType Package { get; set; }
        Length Length { get; set; }
        Weight Weight { get; set; }
        Currency Currency { get; set; }
        decimal Quote { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
