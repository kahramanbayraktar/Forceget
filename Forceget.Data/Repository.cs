using Domain.Entities;

namespace Forceget.Data
{
    public class Repository : IRepository
    {
        public Task<IEnumerable<Offer>> GetOffersByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}