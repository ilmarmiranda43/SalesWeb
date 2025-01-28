using Microsoft.AspNetCore.Mvc;

namespace SystemSallesWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
