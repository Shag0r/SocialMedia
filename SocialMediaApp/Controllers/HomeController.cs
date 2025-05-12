using Microsoft.AspNetCore.Mvc;
using SocialMediaApp.Models;
using System.Diagnostics;

namespace SocialMediaApp.Controllers
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
            return View();
        }

      

        
    }
}
