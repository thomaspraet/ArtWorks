using Microsoft.AspNetCore.Mvc;

namespace ArtWorks.Web.Controllers
{
    public class TechnicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
