using Domain.Entities;

namespace Forceget.WebUI.Models.Offer
{
    public class OfferCreateViewModel
    {
        public Mode Mode { get; set; }
        public MovementType Movement { get; set; }
        public Incoterm Incoterm { get; set; }
        public PackageType Package { get; set; }
        public Length Length { get; set; }
        public Weight Weight { get; set; }
        public Currency Currency { get; set; }
        public decimal Quote { get; set; }
    }
}
