using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forceget.Data
{
    public class OfferContext : DbContext
    {
        public OfferContext(DbContextOptions<OfferContext> options) : base(options)
        {

        }

        public  DbSet<Offer> Offers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Add custom modifications if needed

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
