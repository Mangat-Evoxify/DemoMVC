using DemoMVC.Models;
using DemoMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace DemoMVC.Controllers
{
    [Authorize]
    public class AddressController : Controller
    {
        private readonly SmartyService _smartyService;

        public AddressController(SmartyService smartyService)
        {
            _smartyService = smartyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AddressRequestViewModel model)
        {
            var json = await _smartyService.ValidateAddressAsync(model);
            var parsed = JArray.Parse(json);

            if (parsed.Count == 0)
            {
                ViewBag.Message = "Address not found or invalid.";
                return View(model);
            }

            var deliveryLine = parsed[0]["delivery_line_1"]?.ToString();
            var lastLine = parsed[0]["last_line"]?.ToString();

            ViewBag.Message = $"Validated: {deliveryLine}, {lastLine}";
            return View(model);
        }
    }
}
