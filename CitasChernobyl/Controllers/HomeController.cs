using CitasChernobyl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Microsoft.AspNetCore.Authorization;

namespace CitasChernobyl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize(Roles = "Administrador,Empleado,Cliente")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public IActionResult Citas()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public IActionResult Clientes()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public IActionResult Empleados()
        {
            return View();
        }
        [Authorize(Roles = "Administrador")]
        public IActionResult Informes()
        {
            return View();
        }
        [Authorize(Roles = "Cliente")]
        public IActionResult Perfil_Cliente ()
        {
            return View();
        }
        [Authorize(Roles = "Cliente")]
        public IActionResult Agendar_Cita()
        {
            return View();
        }
        [Authorize(Roles = "Cliente")]
        public IActionResult Historial_Servicios()
        {
            return View();
        }

       

        [Authorize(Roles = "Empleado")]
        public IActionResult Consultar_Agenda()
        {
            return View();
        }

       

        public IActionResult Salir()
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
    }
}