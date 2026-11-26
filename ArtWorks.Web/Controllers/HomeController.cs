using ArtWorks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtWorks.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
