using Domain.Entities;
using Forceget.WebUI.Models.Offer;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebUI.Controllers
{
    public class OfferController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _client;

        public OfferController(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new()
            {
                BaseAddress = new Uri(_configuration.GetConnectionString("ApiBaseAddress")!)
            };
        }

        public async Task<IActionResult> Index()
        {
            var userName = "karr";
            var offers = await _client.GetFromJsonAsync<IEnumerable<Offer>>($"offer/{userName}"); // TODO: adjust async

            return View(offers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Mode,Movement,Incoterm,Package,Length,Weight,Currency,Quote")] OfferCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Offer offer = new()
                {
                    Currency = model.Currency,
                    Incoterm = model.Incoterm,
                    Length = model.Length,
                    Mode = model.Mode,
                    Movement = model.Movement,
                    Package = model.Package,
                    Quote = model.Quote,
                    Weight = model.Weight,
                    UserName = "karr",
                    CreatedAt = DateTime.UtcNow
                };

                await _client.PostAsJsonAsync("offer", offer); // TODO: adjust async

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
