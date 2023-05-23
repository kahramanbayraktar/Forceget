using Domain.Entities;

namespace Forceget.Data
{
    public interface IRepository // TODO: make this generic
    {
        Task<IEnumerable<Offer>> GetOffersByUserName(string userName);
    }
}