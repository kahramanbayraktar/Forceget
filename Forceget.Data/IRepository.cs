using Domain.Entities;

namespace Forceget.Data
{
    public interface IRepository
    {
        Task<IEnumerable<Offer>> GetOffersByUserName(string userName);
    }
}