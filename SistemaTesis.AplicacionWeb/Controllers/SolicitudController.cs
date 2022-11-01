using Microsoft.AspNetCore.Mvc;

namespace SistemaTesis.AplicacionWeb.Controllers
{
    public class SolicitudController : Controller
    {

        public IActionResult Solicitudes()
        {
            return View();
        }

        public IActionResult NuevaSolicitud()
        {
            return View();
        }

        public IActionResult HistorialSolicitudes()
        {
            return View();
        }
    }
}
