using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebUI.Controllers
{
    public class OfferController : Controller
    {
        private readonly IConfiguration _configuration;

        public OfferController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri(_configuration.GetConnectionString("ApiBaseAddress")!)
            };

            var userName = "karr";
            var offers = await client.GetFromJsonAsync<IEnumerable<Offer>>($"offer/{userName}"); // TODO: adjust async

            return View(offers);
        }
    }
}
