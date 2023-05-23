using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Offer")]
    public class Offer
    {
        public int OfferId { get; set; }
        public Mode Mode { get; set; }
        public MovementType Movement { get; set; }
        public Incoterm Incoterm { get; set; }
        public PackageType Package { get; set; }
        public Length Length { get; set; }
        public Weight Weight { get; set; }
        public Currency Currency { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quote { get; set; }
        
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
