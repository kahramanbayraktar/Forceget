namespace Domain.Entities
{
    public class Offer
    {
        Mode Mode { get; set; }
        MovementType Movement { get; set; }
        Incoterm Incoterm { get; set; }
        PackageType Package { get; set; }
        Length Length { get; set; }
        Weight Weight { get; set; }
        Currency Currency { get; set; }
    }
}
