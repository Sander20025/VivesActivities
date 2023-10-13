using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VivesActivities.Ui.Mvc.Models;
using Activity = System.Diagnostics.Activity;

namespace VivesActivities.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var activities = GetActivities();
            return View(activities);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IList<VivesActivity> GetActivities()
        {
            return new List<VivesActivity>
            {
                new VivesActivity
                {
                    Name = "Basket",
                    Location = "Bij IWT"
                },
                new VivesActivity
                {
                    Name = "Basket",
                    Location = "Bij IWT"
                },
                new VivesActivity
                {
                    Name = "Basket",
                    Location = "Bij IWT"
                }
            };
        }
    }
}