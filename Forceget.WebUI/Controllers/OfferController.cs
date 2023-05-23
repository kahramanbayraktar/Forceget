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

        public IActionResult Index()
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri(_configuration.GetConnectionString("ApiBaseAddress")!)
            };

            var userName = "karr";
            var offers = client.GetFromJsonAsync<IEnumerable<Offer>>($"/offer/{userName}").GetAwaiter(); // TODO: adjust async

            return View();
        }
    }
}
