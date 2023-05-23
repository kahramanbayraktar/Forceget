using Domain.Entities;
using Forceget.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IRepository _repository;

        public OfferController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            var offers = await _repository.GetOffersByUserName(userName);

            return Ok(offers);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Offer offer)
        {
            await _repository.CreateOffer(offer);

            return Ok();
        }
    }
}
