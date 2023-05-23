using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forceget.Data
{
    public class SqlRepository : IRepository
    {
        private readonly OfferContext _context;

        public SqlRepository(OfferContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Offer>> GetOffersByUserName(string userName)
        {
            return await _context.Offers.Where(x => x.UserName == userName).ToListAsync();
        }
    }
}