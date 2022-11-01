using Microsoft.AspNetCore.Mvc;

namespace SistemaTesis.AplicacionWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
