using Microsoft.AspNetCore.Mvc;

namespace CitasChernobyl.Controllers
{
    public class SesionFinalizadaController : Controller
    {
        public IActionResult SesionFinalizada()
        {
            return View();
        }
    }
}
