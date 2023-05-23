using Domain.Entities;

namespace Forceget.Data.Repositories
{
    public interface IRepository // TODO: make this generic
    {
        Task CreateOffer(Offer offer);
        Task<IEnumerable<Offer>> GetOffersByUserName(string userName);
    }
}