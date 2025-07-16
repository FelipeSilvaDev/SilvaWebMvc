using Microsoft.AspNetCore.Mvc;

namespace SilvaWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
