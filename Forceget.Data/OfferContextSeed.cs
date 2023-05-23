using Domain.Entities;

namespace Forceget.Data
{
    public class OfferContextSeed
    {
        public static async Task SeedAsync(OfferContext context)
        {
            if (!context.Offers.Any())
            {
                context.Offers.AddRange(
                    new List<Offer>
                    {
                        new Offer {
                            CreatedAt = DateTime.UtcNow,
                            Currency = Currency.USD,
                            Incoterm= Incoterm.DeliveredDutyPaid,
                            Length = Length.CM,
                            Mode = Mode.FCL,
                            Movement = MovementType.PortToPort,
                            Package = PackageType.Cartons,
                            Quote = 1050.50M,
                            Weight = Weight.KG,
                            UserName = "karr"
                        },
                        new Offer {
                            CreatedAt = DateTime.UtcNow.AddDays(-3),
                            Currency = Currency.TRY,
                            Incoterm= Incoterm.DeliveredAtPlace,
                            Length = Length.IN,
                            Mode = Mode.Air,
                            Movement = MovementType.DoorToDoor,
                            Package = PackageType.Boxes,
                            Quote = 345.00M,
                            Weight = Weight.LB,
                            UserName = "karr"
                        }
                    }
                );
                await context.SaveChangesAsync();
            }
        }
    }
}
