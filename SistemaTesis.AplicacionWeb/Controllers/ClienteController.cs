﻿using Microsoft.AspNetCore.Mvc;

namespace SistemaTesis.AplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
