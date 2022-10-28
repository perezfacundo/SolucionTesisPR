using Microsoft.AspNetCore.Mvc;

namespace SistemaTesis.AplicacionWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
